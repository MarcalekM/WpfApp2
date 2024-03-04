using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            lblEredmeny.Content += btn1.Content.ToString();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            lblEredmeny.Content += btn2.Content.ToString();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            lblEredmeny.Content += btn3.Content.ToString();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            lblEredmeny.Content += btn4.Content.ToString();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            lblEredmeny.Content += btn5.Content.ToString();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            lblEredmeny.Content += btn6.Content.ToString();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            lblEredmeny.Content += btn7.Content.ToString();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            lblEredmeny.Content += btn8.Content.ToString();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            lblEredmeny.Content += btn9.Content.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lblEredmeny.Content.Equals("2563")) MessageBox.Show("Helyes válasz", "Jelszó ellenőrző", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            else MessageBox.Show("Rossz válasz", "Jelszó ellenőrző", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}