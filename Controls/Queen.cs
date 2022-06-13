using System.Windows;
using System.Windows.Controls;

namespace Custom_Control_App.Controls
{
   public class Queen : Button
    {
        static Queen()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Queen), new FrameworkPropertyMetadata(typeof(Queen)));
        }
    }
}
