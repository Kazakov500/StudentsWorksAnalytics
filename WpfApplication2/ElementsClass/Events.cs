using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace StudentsWorkAnalytics.ElementsClass
{
    public static class Events
    {
        public static void GotFocus(TextBox sender)
        {
            if (((TextBox)sender).Text == ((TextBox)sender).Tag.ToString())
            {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        public static void LostFocus(TextBox sender)
        {
            if ((((TextBox)sender).Text == "") || (((TextBox)sender).Text == ((TextBox)sender).Tag.ToString()))
            {
                ((TextBox)sender).Text = ((TextBox)sender).Tag.ToString();
                ((TextBox)sender).Foreground = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            }
        }
    }
}
