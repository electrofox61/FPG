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
using System.Windows.Shapes;
using System.IO;

namespace FPG
{
    /// <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        int ero, ved, moz, intl, xp, szint;
        string nev, klassz;
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            nev = neve.Text;
        }

        public Window5()
        {
            InitializeComponent();
        }
        private void tovabb_Click(object sender, RoutedEventArgs e)
        {
            if (nev == "")
            {
                hibaT.Text = "Hiba: meg kell adnod a neveiket a karaktereknek!!";
            }
            else
            {
                try
                {
                    StreamReader stat = new StreamReader(nev + ".txt");
                    nev = stat.ReadLine();
                    ero = Convert.ToInt32(stat.ReadLine());
                    ved = Convert.ToInt32(stat.ReadLine());
                    moz = Convert.ToInt32(stat.ReadLine());
                    intl = Convert.ToInt32(stat.ReadLine());
                    klassz = stat.ReadLine();
                    xp = Convert.ToInt32(stat.ReadLine());
                    stat.Close();
                    szint = Convert.ToInt32(xp / 1000);
                }
                catch (FileNotFoundException)
                {
                    hibaT.Text = "Hiba: nincs ilyen karakter!";
                }
            }
            karakterleiras.Content = "Neve: " + nev + "\n Ereje: " + ero + "\n Védelme: " + ved + "\n Mozgékonysága: " + moz + "\n Intelligenciája: " + intl + "\n Klasszja: " + klassz + "\n Az tapasztalat pontjai: " + xp + "\n A szintje: " + szint;
        }
    }
}
