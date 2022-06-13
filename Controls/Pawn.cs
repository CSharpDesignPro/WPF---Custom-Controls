using System.Windows;
using System.Windows.Controls;

namespace Custom_Control_App.Controls
{
   public class Pawn : Button
    {
        static Pawn()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Pawn), new FrameworkPropertyMetadata(typeof(Pawn)));
        }
    }
}
