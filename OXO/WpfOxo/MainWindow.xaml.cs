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

namespace WpfOxo
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
        int index = 0;
        string x = "X";
        string o = "O";
        string empty = "";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if(index % 2 == 0)
            {
                btn.Content = x;
                btn.FontSize = 25;
            }
            else
            {
                btn.Content = o;
                btn.FontSize = 25;
            }
                index++;

            // X-STREAKS
            //winstreak X: horizontale
            if (Convert.ToString(btn1.Content) == x && Convert.ToString(btn2.Content) == x && Convert.ToString(btn3.Content) == x)
            {
                lblWinner.Content = "Winner X has won";

                btn1.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn2.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn3.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));

                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;


            }
            if (Convert.ToString(btn4.Content) == x && Convert.ToString(btn5.Content) == x && Convert.ToString(btn6.Content) == x)
            {
                lblWinner.Content = "Winner X has won";

                btn4.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn5.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn6.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));

                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
            }
            if (Convert.ToString(btn7.Content) == x && Convert.ToString(btn8.Content) == x && Convert.ToString(btn9.Content) == x)
            {
                lblWinner.Content = "Winner X has won";
                btn7.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn8.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn9.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));


                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
            }
            //winstreak X: verticale
            if (Convert.ToString(btn1.Content) == x && Convert.ToString(btn4.Content) == x && Convert.ToString(btn7.Content) == x)
            {
                lblWinner.Content = "Winner X has won";
                btn1.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn4.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn7.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));


                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
            }
            if (Convert.ToString(btn2.Content) == x && Convert.ToString(btn5.Content) == x && Convert.ToString(btn8.Content) == x)
            {
                lblWinner.Content = "Winner X has won";
                btn2.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn5.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn8.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));


                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
            }
            if (Convert.ToString(btn3.Content) == x && Convert.ToString(btn6.Content) == x && Convert.ToString(btn9.Content) == x)
            {
                lblWinner.Content = "Winner X has won";
                btn3.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn6.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn9.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));


                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
            }
            //winstreak X: diagonale
            if (Convert.ToString(btn1.Content) == x && Convert.ToString(btn5.Content) == x && Convert.ToString(btn9.Content) == x)
            {
                lblWinner.Content = "Winner X has won";
                btn1.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn5.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn9.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));


                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
            }
            if (Convert.ToString(btn3.Content) == x && Convert.ToString(btn5.Content) == x && Convert.ToString(btn7.Content) == x)
            {
                lblWinner.Content = "Winner X has won";
                btn3.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn5.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn7.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));


                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
            }

            //O STREAKS

            //winstreak O: horizontale
            if (Convert.ToString(btn1.Content) == o && Convert.ToString(btn2.Content) == o && Convert.ToString(btn3.Content) == o)
            {
                lblWinner.Content = "Winner O has won";
                btn1.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn2.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn3.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));

                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
            }
            if (Convert.ToString(btn4.Content) == o && Convert.ToString(btn5.Content) == o && Convert.ToString(btn6.Content) == o)
            {
                lblWinner.Content = "Winner O has won";
                btn4.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn5.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn6.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));

                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
            }
            if (Convert.ToString(btn7.Content) == o && Convert.ToString(btn8.Content) == o && Convert.ToString(btn9.Content) == o)
            {
                lblWinner.Content = "Winner O has won";
                btn7.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn8.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn9.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));

                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
            }
            //winstreak O: verticale
            if (Convert.ToString(btn1.Content) == o && Convert.ToString(btn4.Content) == o && Convert.ToString(btn7.Content) == o)
            {
                lblWinner.Content = "Winner O has won";
                btn1.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn4.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn7.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));

                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
            }
            if (Convert.ToString(btn2.Content) == o && Convert.ToString(btn5.Content) == o && Convert.ToString(btn8.Content) == o)
            {
                lblWinner.Content = "Winner O has won";
                btn2.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn5.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn8.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));

                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
            }
            if (Convert.ToString(btn3.Content) == o && Convert.ToString(btn6.Content) == o && Convert.ToString(btn9.Content) == o)
            {
                lblWinner.Content = "Winner O has won";
                btn3.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn6.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn9.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));

                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
            }
            //winstreak O: diagonal
            if (Convert.ToString(btn1.Content) == o && Convert.ToString(btn5.Content) == o && Convert.ToString(btn9.Content) == o)
            {
                lblWinner.Content = "Winner O has won";
                btn1.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn5.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn9.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));

                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
            }
            if (Convert.ToString(btn3.Content) == o && Convert.ToString(btn5.Content) == o && Convert.ToString(btn7.Content) == o)
            {
                lblWinner.Content = "Winner O has won";
                btn3.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn5.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));
                btn7.Foreground = new SolidColorBrush(Color.FromRgb(0, 150, 0));

                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;
                btn6.IsEnabled = false;
                btn7.IsEnabled = false;
                btn8.IsEnabled = false;
                btn9.IsEnabled = false;
            }
            // RESTART
            if (Convert.ToString(btn1.Content) != empty || Convert.ToString(btn2.Content) != empty || Convert.ToString(btn3.Content) != empty || Convert.ToString(btn4.Content) != empty || Convert.ToString(btn5.Content) != empty || Convert.ToString(btn6.Content) != empty || Convert.ToString(btn7.Content) != empty || Convert.ToString(btn8.Content) != empty || Convert.ToString(btn9.Content) != empty )
            {
                btnRestart.IsEnabled = true;
            }

            

            
        }

        private void btnRestart_Click(object sender, RoutedEventArgs e)
        {
            btnRestart.IsEnabled = false;

            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;

            btn1.Content = empty;
            btn2.Content = empty;
            btn3.Content = empty;
            btn4.Content = empty;
            btn5.Content = empty;
            btn6.Content = empty;
            btn7.Content = empty;
            btn8.Content = empty;
            btn9.Content = empty;

            lblWinner.Content = empty;


            btn1.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            btn2.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            btn3.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            btn4.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            btn5.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            btn6.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            btn7.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            btn8.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            btn9.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }
    }
}
