using System.Windows;
using System.Windows.Controls;

namespace Custom_Control_App.Controls
{
    public class Rook : Button
    {
        static Rook()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Rook), new FrameworkPropertyMetadata(typeof(Rook)));
        }
    }
}
