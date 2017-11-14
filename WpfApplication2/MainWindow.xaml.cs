using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using StudentsWorkAnalytics.ElementsClass;
using WpfApplication2.UserControls;
using WpfApplication2.ElementsClass;
using StudentsWorkAnalytics.UserControls;
using System.Windows.Forms.Integration;
using System.Xml;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace StudentsWorkAnalytics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Parameter> Parameters = new List<Parameter>();
        List<StudentsWork> Works = new List<StudentsWork>();

        public MainWindow()
        {
            InitializeComponent();


            tb_DB_Name.TextChanged += tb_DB_TextChanged;
            tb_DB_Surname.TextChanged += tb_DB_TextChanged;
            tb_DB_Group.TextChanged += tb_DB_TextChanged;
            //Style s = new Style();
            //s.Setters.Add(new Setter(UIElement.VisibilityProperty, Visibility.Collapsed));
            //tabControl.ItemContainerStyle = s;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedItem = tabControl.Items.Cast<TabItem>()
                                        .Where(item => item.Header.ToString() == "Add Work")
                                        .FirstOrDefault();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Parameter param = new Parameter { Number = 1, Title = "Title of param", Description = "description", FromVal = 0, ToVal = 10 };

            //UIElement ParamRow = new UIElement();
            //Grid gr = new Grid();

            //Border brd = new Border();
            //var brdCont = brd.DataContext as Parameter;

            //StackParams.Children.Add()

            //ListViewItem Item = new ListViewItem();
            //Item.ContentTemplate = (DataTemplate)this.FindResource("LI_Parameter");
            //Item.Content = param;
            //listView.Items.Add(Item);


            ParameterItem PItem_1 = new ParameterItem();

            PItem_1.tb_FromVal.TextChanged += Tb_FromVal_TextChanged;
            PItem_1.tb_ToVal.TextChanged += Tb_FromVal_TextChanged;
            PItem_1.tb_Title.TextChanged += Tb_FromVal_TextChanged;
            PItem_1.tb_Koeff.TextChanged += Tb_FromVal_TextChanged;
            PItem_1.rtb_Description.TextChanged += Tb_FromVal_TextChanged;
            PItem_1.btn_ParamDelete.Click += Btn_ParamDelete_Click;

            PItem_1.tBl_Param_Num.Text = (StackParams.Children.Count+1).ToString();

            StackParams.Children.Add(PItem_1);

            SaveParamsToList();
        }

        private void Btn_ParamDelete_Click(object sender, RoutedEventArgs e)
        {
            DependencyObject ucParent = (Button)sender;
            while (!(ucParent is ParameterItem))
                ucParent = LogicalTreeHelper.GetParent(ucParent);

            StackParams.Children.Remove((ParameterItem)(ucParent));
            int p_ind = 1;
            foreach (var p in StackParams.Children)
                ((ParameterItem)p).tBl_Param_Num.Text = (p_ind++).ToString();
            SaveParamsToList();
        }

        private void Tb_FromVal_TextChanged(object sender, TextChangedEventArgs e)
        {
            SaveParamsToList();
        }

        private void SaveParamsToList()
        {
            Parameters.Clear();
            int i = 0;
            try
            {
                foreach (var Param in StackParams.Children)
                {
                    Parameter p = new Parameter();
                    p.Number = i++;
                    p.Title = ((ParameterItem)Param).tb_Title.Text;
                    p.Description = new TextRange(((ParameterItem)Param).rtb_Description.Document.ContentStart, ((ParameterItem)Param).rtb_Description.Document.ContentEnd).Text;
                    p.FromVal = Convert.ToInt32(((ParameterItem)Param).tb_FromVal.Text);
                    p.ToVal = Convert.ToInt32(((ParameterItem)Param).tb_ToVal.Text);
                    p.K = Convert.ToDouble(((ParameterItem)Param).tb_Koeff.Text);
                    Parameters.Add(p);
                }

                sp_ParametersInput.Children.Clear();
                foreach (var item in Parameters)
                {
                    ParamInputControl ParamInp = new ParamInputControl(item.Number, item.Title, item.Description, item.FromVal);
                    ParamInp.tb_Value.TextChanged += Tb_Value_TextChanged;
                    sp_ParametersInput.Children.Add(ParamInp);
                }
            } catch (Exception ex)
            { }
        }

        private void Tb_Value_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double Mark = 0;
                for (int i = 0; i < sp_ParametersInput.Children.Count; i++)
                    Mark += Convert.ToInt32(((ParamInputControl)sp_ParametersInput.Children[i]).tb_Value.Text) * Parameters[i].K;
                tBl_Mark.Text = Mark.ToString();
            }
            catch (Exception ex)
            {

            }

        }

        private void btn_AddStudentsWork_Click(object sender, RoutedEventArgs e)
        {
            StudentsWork Work = new StudentsWork();
            Work.Number = Works.Count;
            Work.Name = tBl_Name.Text;
            Work.Surname = tBl_Surname.Text;
            Work.Group = tBl_Group.Text;
            foreach (var item in sp_ParametersInput.Children)
                Work.Parameters.Add(Convert.ToInt32(((ParamInputControl)item).tb_Value.Text));
            double Mark = 0;
            for (int i = 0; i < Work.Parameters.Count; i++)
                Mark += Work.Parameters[i] * Parameters[i].K;
            Work.Mark = Mark;

            Works.Add(Work);
            FillDB();
        }


        private void FillDB()
        {
            //int ind = 0;
            sp_DataBase.Children.Clear();
            foreach (var work in Works)
            {
                StudentsWorkInDB w_element = new StudentsWorkInDB();
                w_element.tBl_NumberOfStudentsWork.Text = (work.Number).ToString();
                w_element.tb_Name.Text = work.Name;
                w_element.tb_Surname.Text = work.Surname;
                w_element.tb_Group.Text = work.Group;
                w_element.tBl_Mark.Text = work.Mark.ToString();

                sp_DataBase.Children.Add(w_element);

                w_element.MouseDown += W_element_MouseDown;
                w_element.btn_Delete.Click += Btn_Delete_Click;
            }
        }

        private void Btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            var ind = (TextBlock)(((Grid)((Button)sender).Parent).Children[0]);
            int index = Convert.ToInt32(ind.Text);
            Works.RemoveAt(index);
            int i = 0;
            foreach (var w in Works)
                w.Number = i++;
            tb_DB_search_TextChanged(null, null);
        }

        private void W_element_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FillCurrDBFields(Convert.ToInt32(((StudentsWorkInDB)sender).tBl_NumberOfStudentsWork.Text));
        }

        private void FillCurrDBFields(int index)
        {
            StudentsWork work = (Works.Where(w => (w.Number == index))).First();

            tBl_DB_Number.Text = work.Number.ToString();
            tb_DB_Name.Text = work.Name;
            tb_DB_Surname.Text = work.Surname;
            tb_DB_Group.Text = work.Group;

            int ind = 0;
            sp_CurrentParamsInDB.Children.Clear();
            foreach (var p in work.Parameters)
            {
                ParamInDB PInDB = new ParamInDB(Parameters[ind].Number,
                                                Parameters[ind].Title,
                                                p);
                PInDB.tb_Value.TextChanged += Tb_ValueInParamDB_TextChanged;
                sp_CurrentParamsInDB.Children.Add(PInDB);
                ind++;
            }
        }

        private void Tb_ValueInParamDB_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int param_ind = Convert.ToInt32(((TextBlock)(((Grid)(((TextBox)sender).Parent)).Children[0])).Text);
                int work_ind = Convert.ToInt32(tBl_DB_Number.Text);
                Works[work_ind].Parameters[param_ind] = Convert.ToInt32(((TextBox)sender).Text);

                double Mark = 0;
                for (int i = 0; i < Works[work_ind].Parameters.Count; i++)
                    Mark += Works[work_ind].Parameters[i] * Parameters[i].K;
                Works[work_ind].Mark = Mark;

                FillDB();
            } catch (Exception ex)
            { }
        }

        private void SaveNewValuesOfStudentsWork()
        {

        }

        private void btn_DB_test_Click(object sender, RoutedEventArgs e)
        {
            FillDB();
        }

        private void tb_DB_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                switch (((TextBox)sender).Name)
                {
                    case "tb_DB_Surname":
                        Works[Convert.ToInt32(tBl_DB_Number.Text)].Surname = ((TextBox)sender).Text;
                        break;
                    case "tb_DB_Group":
                        Works[Convert.ToInt32(tBl_DB_Number.Text)].Group = ((TextBox)sender).Text;
                        break;
                    default: //tb_DB_Name
                        Works[Convert.ToInt32(tBl_DB_Number.Text)].Name = ((TextBox)sender).Text;
                        break;
                }
                FillDB();
            } catch (Exception ex)
            {

            }
        }

        private void AddStWorkInDB_Click(object sender, RoutedEventArgs e)
        {
            AddEmptyStudentWorkInDB();
        }

        private void AddEmptyStudentWorkInDB()
        {
            StudentsWork Work = new StudentsWork();
            Work.Number = Works.Count;
            Work.Name = "Name";
            Work.Surname = "Surname";
            Work.Group = "Group";
            foreach (var item in Parameters)
                Work.Parameters.Add(item.FromVal);
            double Mark = 0;
            for (int i = 0; i < Work.Parameters.Count; i++)
                Mark += Work.Parameters[i] * Parameters[i].K;
            Work.Mark = Mark;

            Works.Add(Work);
            FillDB();
            RefrashAnalysisTab();
        }

        private void tb_DB_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            //int ind = 0;
            sp_DataBase.Children.Clear();
            foreach (var work in Works)
            {
                if ((tb_DB_search.Text.Trim()) == "" || (tb_DB_search.Text.Trim()) == "Search" ||
                                      (
                                        work.Name.Contains(tb_DB_search.Text) ||
                                        work.Surname.Contains(tb_DB_search.Text) ||
                                        work.Group.Contains(tb_DB_search.Text) ||
                                        work.Mark.ToString().Contains(tb_DB_search.Text)
                                      )
                    )
                {
                    StudentsWorkInDB w_element = new StudentsWorkInDB();
                    w_element.tBl_NumberOfStudentsWork.Text = (work.Number).ToString();
                    w_element.tb_Name.Text = work.Name;
                    w_element.tb_Surname.Text = work.Surname;
                    w_element.tb_Group.Text = work.Group;
                    w_element.tBl_Mark.Text = work.Mark.ToString();

                    sp_DataBase.Children.Add(w_element);

                    w_element.MouseDown += W_element_MouseDown;
                    w_element.btn_Delete.Click += Btn_Delete_Click;
                }
            }
        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();            
        }

        private void btn_Minimaze_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void btn_Maximize_Click(object sender, RoutedEventArgs e)
        {

            if (WindowState == WindowState.Maximized) WindowState = WindowState.Normal;
            else WindowState = WindowState.Maximized;
        }

        private void RefrashAnalysisTab()
        {
            try
            {
                sp_Works_Analysis.Children.Clear();
                foreach (var work in Works)
                {
                    if ((tb_DB_search_Analysis.Text.Trim()) == "" || (tb_DB_search.Text.Trim()) == "Search" ||
                                          (
                                            work.Name.Contains(tb_DB_search_Analysis.Text) ||
                                            work.Surname.Contains(tb_DB_search_Analysis.Text) ||
                                            work.Group.Contains(tb_DB_search_Analysis.Text) ||
                                            work.Mark.ToString().Contains(tb_DB_search_Analysis.Text)
                                          )
                        )
                    {
                        StudentsWorkInAnalysis w_element = new StudentsWorkInAnalysis();
                        w_element.tBl_Num.Text = (work.Number).ToString();
                        w_element.tBl_Name.Text = work.Name;
                        w_element.tBl_SName.Text = work.Surname;
                        w_element.tBl_Group.Text = work.Group;
                        w_element.tBl_Mark.Text = work.Mark.ToString();

                        sp_Works_Analysis.Children.Add(w_element);

                        //w_element.MouseDown += W_element_MouseDown;
                        //w_element.btn_Delete.Click += Btn_Delete_Click;
                    }
                }


                RefrashCharts();
            } catch (Exception ex)
            { }
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RefrashAnalysisTab();

            
        }

        private void RefrashCharts()
        {
            RefrashParallelCoordinatesChart();
            RefrashMarksDotsChart();
        }

        private void RefrashParallelCoordinatesChart()
        {
           chart_ParallelCoordinates.Series.Clear();
            chart_ParallelCoordinates.ChartAreas.Clear();

            chart_ParallelCoordinates.ChartAreas.Add("MainChartArea");

            

            Random rnd = new Random();

            int ind = 0;
            foreach (var work in Works)
            {
                chart_ParallelCoordinates.Series.Add("s" + ind.ToString());
                chart_ParallelCoordinates.Series["s" + ind.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                foreach (var param in work.Parameters)
                {
                    chart_ParallelCoordinates.Series["s" + ind.ToString()].Points.Add(rnd.Next(20));
                }
                ind++;
            }
        }

        private void RefrashMarksDotsChart()
        {
            //chart_MarksDots.Series.Clear();
            //chart_MarksDots.ChartAreas.Clear();

            //chart_MarksDots.ChartAreas.Add("MainChartArea");
            Random rnd = new Random();
            chart_MarksDots.Series[0].Points.Clear();
            foreach (var work in Works)
            {
                    chart_MarksDots.Series[0].Points.Add(rnd.Next(0,50)/ 10.0);//work.Mark);
            }
        }

        private void tb_DB_search_Analysis_TextChanged(object sender, TextChangedEventArgs e)
        {
            RefrashAnalysisTab();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Parameters to XML";
            saveFileDialog.Filter = "XML|*.xml";
            if (saveFileDialog.ShowDialog() == true)
            {
                List<Parameter> myObject = new List<Parameter>();
                myObject = Parameters;
                XmlSerializer mySerializer = new XmlSerializer(typeof(List<Parameter>));
                StreamWriter myWriter = new StreamWriter(saveFileDialog.FileName);
                mySerializer.Serialize(myWriter, myObject);
                myWriter.Close();
            }

        }

        public class StudentsAndParameters
        {
            public List<Parameter> Params_;
            public List<StudentsWork> Works_;
    }

        private void btn_SaveStudentsWorksToXML_Click(object sender, RoutedEventArgs e)
        {
            StudentsAndParameters SaP = new StudentsAndParameters();
            SaP.Params_ = Parameters;
            SaP.Works_ = Works;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save All Data to XML";
            saveFileDialog.Filter = "XML|*.xml";
            if (saveFileDialog.ShowDialog() == true)
            {
                
                XmlSerializer mySerializer = new XmlSerializer(typeof(StudentsAndParameters));
                StreamWriter myWriter = new StreamWriter(saveFileDialog.FileName);
                mySerializer.Serialize(myWriter, SaP);
                myWriter.Close();
            }


        }

        private void btn_LoadParameters_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Save Parameters to XML";
            openFileDialog.Filter = "XML|*.xml";
            if (openFileDialog.ShowDialog() == true)
            {
                XmlSerializer mySerializer =
                new XmlSerializer(typeof(List<Parameter>));
                FileStream myFileStream =
                new FileStream(openFileDialog.FileName, FileMode.Open);
                Parameters = (List<Parameter>)mySerializer.Deserialize(myFileStream);
            }

            foreach (var p in Parameters)
            {


                ParameterItem PItem_1 = new ParameterItem();

                PItem_1.tBl_Param_Num.Text = p.Number.ToString();
                PItem_1.tb_Title.Text = p.Title;
                PItem_1.rtb_Description.Document.Blocks.Clear();
                PItem_1.rtb_Description.Document.Blocks.Add(new Paragraph(new Run(p.Description)));
                PItem_1.tb_FromVal.Text = p.FromVal.ToString();
                PItem_1.tb_ToVal.Text = p.ToVal.ToString();
                PItem_1.tb_Koeff.Text = p.K.ToString();

                PItem_1.tb_FromVal.TextChanged += Tb_FromVal_TextChanged;
                PItem_1.tb_ToVal.TextChanged += Tb_FromVal_TextChanged;
                PItem_1.tb_Title.TextChanged += Tb_FromVal_TextChanged;
                PItem_1.tb_Koeff.TextChanged += Tb_FromVal_TextChanged;
                PItem_1.rtb_Description.TextChanged += Tb_FromVal_TextChanged;
                PItem_1.btn_ParamDelete.Click += Btn_ParamDelete_Click;

                PItem_1.tBl_Param_Num.Text = (StackParams.Children.Count + 1).ToString();

                StackParams.Children.Add(PItem_1);

            }
            SaveParamsToList();
        }

        private void btn_LoadStudentsWorksData_Copy_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Data with Students Works and Parameters from XML";
            openFileDialog.Filter = "XML|*.xml";

            StudentsAndParameters SaP = new StudentsAndParameters();
            if (openFileDialog.ShowDialog() == true)
            {
                XmlSerializer mySerializer = new XmlSerializer(typeof(StudentsAndParameters));
                FileStream myFileStream =
                new FileStream(openFileDialog.FileName, FileMode.Open);
                SaP = (StudentsAndParameters)mySerializer.Deserialize(myFileStream);
            }

            foreach (var p in SaP.Params_)
            {


                ParameterItem PItem_1 = new ParameterItem();

                PItem_1.tBl_Param_Num.Text = p.Number.ToString();
                PItem_1.tb_Title.Text = p.Title;
                PItem_1.rtb_Description.Document.Blocks.Clear();
                PItem_1.rtb_Description.Document.Blocks.Add(new Paragraph(new Run(p.Description)));
                PItem_1.tb_FromVal.Text = p.FromVal.ToString();
                PItem_1.tb_ToVal.Text = p.ToVal.ToString();
                PItem_1.tb_Koeff.Text = p.K.ToString();

                PItem_1.tb_FromVal.TextChanged += Tb_FromVal_TextChanged;
                PItem_1.tb_ToVal.TextChanged += Tb_FromVal_TextChanged;
                PItem_1.tb_Title.TextChanged += Tb_FromVal_TextChanged;
                PItem_1.tb_Koeff.TextChanged += Tb_FromVal_TextChanged;
                PItem_1.rtb_Description.TextChanged += Tb_FromVal_TextChanged;
                PItem_1.btn_ParamDelete.Click += Btn_ParamDelete_Click;

                PItem_1.tBl_Param_Num.Text = (StackParams.Children.Count + 1).ToString();

                StackParams.Children.Add(PItem_1);

                
            }
            SaveParamsToList();

            Works = SaP.Works_;

            FillDB();
        }

        private void tb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == ((TextBox)sender).Tag.ToString())
            {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        private void tb_LostFocus(object sender, RoutedEventArgs e)
        {
            if ((((TextBox)sender).Text == "")  || (((TextBox)sender).Text == ((TextBox)sender).Tag.ToString()))
            {
                    ((TextBox)sender).Text = ((TextBox)sender).Tag.ToString();
                    ((TextBox)sender).Foreground = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            }
        }
    }
}
