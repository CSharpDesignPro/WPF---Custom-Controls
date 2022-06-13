using System.Windows;
using System.Windows.Controls;

namespace Custom_Control_App.Controls
{
    public class King : Button
    {
        static King()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(King), new FrameworkPropertyMetadata(typeof(King)));
        }
    }
}
