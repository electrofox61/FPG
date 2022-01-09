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

namespace FPG
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

        private void play_Click(object sender, RoutedEventArgs e)
        {
            Window2 subWindow = new Window2();
            subWindow.Show();
            Window0.Close();
        }

        private void karakterek_Click(object sender, RoutedEventArgs e)
        {
            Window5 subWindow = new Window5();
            subWindow.Show();
        }

        private void sugo_Click(object sender, RoutedEventArgs e)
        {
            Window6 subWindow = new Window6();
            subWindow.Show();
        }

        private void harc_Click(object sender, RoutedEventArgs e)
        {
            Window3 subWindow = new Window3();
            subWindow.Show();
            Window0.Close();
        }

        private void kilep_Click(object sender, RoutedEventArgs e)
        {
            Window0.Close();
        }
    }
}
