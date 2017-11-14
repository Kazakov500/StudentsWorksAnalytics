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
    /// Interaction logic for ParamInputControl.xaml
    /// </summary>
    public partial class ParamInputControl : UserControl
    {
        public ParamInputControl(int Number, string Title, string Description, int value)
        {
            InitializeComponent();

            tBl_Number.Text = (Number + 1).ToString();
            tBl_Title.Text = Title;
            tBl_Description.Text = Description;
            tb_Value.Text = value.ToString();
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
