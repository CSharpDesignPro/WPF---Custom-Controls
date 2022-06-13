
 /// Author : R. Arun Mutharasu
 /// Created On :13-06-2022
 /// YouTube Channel : C# Design Pro  

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

namespace Custom_Control_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Chess Piece Selection //

        public void ChessPiece(object sender, RoutedEventArgs e)
        {
            Description.Text = ((Button)sender).Name switch
            {
                "h2" => "You clicked on Pawn h2.",
                "g2" => "You clicked on Pawn g2.",
                "f2" => "You clicked on Pawn f2.",
                "e2" => "You clicked on Pawn e2.",
                "d2" => "You clicked on Pawn d2.",
                "c2" => "You clicked on Pawn c2.",
                "b2" => "You clicked on Pawn b2.",
                "a2" => "You clicked on Pawn a2.",
                "h1" => "You clicked on Rook h1.",
                "a1" => "You clicked on Rook a1.",
                "g1" => "You clicked on Knight g1.",
                "b1" => "You clicked on Knight b1.",
                "f1" => "You clicked on Bishop f1.",
                "c1" => "You clicked on Bishop c1.",
                "e1" => "You clicked on King e1.",
                "d1" => "You clicked on Queen d1.",
                _ => "",
            };
        }

        private void Board_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Description.Text = "";
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
