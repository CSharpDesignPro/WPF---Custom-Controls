using System.Windows;
using System.Windows.Controls;

namespace Custom_Control_App.Controls
{
   public class Bishop : Button
    {
        static Bishop()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Bishop), new FrameworkPropertyMetadata(typeof(Bishop)));
        }
    }
}
