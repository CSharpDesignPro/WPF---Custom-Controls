using System.Windows;
using System.Windows.Controls;

namespace Custom_Control_App.Controls
{
    public class Knight : Button
    {
        static Knight()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Knight), new FrameworkPropertyMetadata(typeof(Knight)));
        }
    }
}
