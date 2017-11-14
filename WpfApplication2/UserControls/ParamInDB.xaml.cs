using StudentsWorkAnalytics.ElementsClass;
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

namespace WpfApplication2.UserControls
{
    /// <summary>
    /// Interaction logic for ParamInDB.xaml
    /// </summary>
    public partial class ParamInDB : UserControl
    {
        public ParamInDB(int Number, string Title, int Value)
        {
            InitializeComponent();

            tBl_Number.Text = Number.ToString();
            tBl_Title.Text = Title;
            tb_Value.Text = Value.ToString();
        }

        private void tb_GotFocus(object sender, RoutedEventArgs e)
        {
            Events.GotFocus((TextBox)sender);
        }

        private void tb_LostFocus(object sender, RoutedEventArgs e)
        {
            Events.LostFocus((TextBox)sender);
        }
    }
}
