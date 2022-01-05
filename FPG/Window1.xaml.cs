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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        int xp = 0;
        string knev = "";
        int ero = 1;
        int ved = 1;
        int moz = 1;
        int intl = 1;
        int pont = 10;
        public Window1()
        {
            InitializeComponent();
        }
        private void tovabb_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(pontok.Content) == "Pontok: 0")
            {
                if (nev.Text == "")
                {
                    hiba.Text = "Hiba: El kell nevezned a rókádat!";
                }
                else
                {
                    StreamReader klassz = new StreamReader("klassz.txt");
                    string klasz = klassz.ReadLine();
                    StreamWriter swnev = new StreamWriter("nev.txt");
                    swnev.WriteLine(knev);
                    StreamWriter karakter = new StreamWriter(knev +".txt");
                    karakter.WriteLine(knev + "\n" + ero+ "\n" +ved+ "\n" +moz +"\n" +intl +"\n" +klasz +"\n" + xp);
                    klassz.Close();
                    swnev.Close();
                    karakter.Close();
                    Window3 subWindow = new Window3();
                    subWindow.Show();
                    Window2.Close();
                }
            }
            else
            {
                hiba.Text = "Hiba: El kell költened a pontjaidat!";
            }
        }

        
        private void ero1_Click(object sender, RoutedEventArgs e)
        {
            if (ero > 1)
            {
                ero--;
                eroL.Content = "Erő: " + ero;
                pont++;
                pontok.Content = "Pontok: " + pont;
            }
            else
                hiba.Text = "Hiba: Nem lehet 1 alá venni a statjaidat.";
        }
        private void ero2_Click(object sender, RoutedEventArgs e)
        {
            if (pont > 0)
            {
                ero++;
                eroL.Content = "Erő: " + ero;
                pont--;
                pontok.Content = "Pontok: " + pont;
            }
            else
                hiba.Text = "Hiba: Nem lehet kevesebb mint 0 pontod.";
        }
        private void ved1_Click(object sender, RoutedEventArgs e)
        {
            if (ved > 1)
            {
                ved--;
                vedL.Content = "Védelem: " + ved;
                pont++;
                pontok.Content = "Pontok: " + pont;
            }
            else
                hiba.Text = "Hiba: Nem lehet 1 alá venni a statjaidat.";
        }
        private void ved2_Click(object sender, RoutedEventArgs e)
        {
            if (pont > 0)
            {
                ved++;
                vedL.Content = "Védelem: " + ved;
                pont--;
                pontok.Content = "Pontok: " + pont;
            }
            else
                hiba.Text = "Hiba: Nem lehet kevesebb mint 0 pontod.";
        }
        private void moz1_Click(object sender, RoutedEventArgs e)
        {
            if (moz > 1)
            {
                moz--;
                mozL.Content = "Mozgékonyság: " + moz;
                pont++;
                pontok.Content = "Pontok: " + pont;
            }
            else
                hiba.Text = "Hiba: Nem lehet 1 alá venni a statjaidat.";
        }
        private void moz2_Click(object sender, RoutedEventArgs e)
        {
            if (pont > 0)
            {
                moz++;
                mozL.Content = "Mozgékonyság: " + moz;
                pont--;
                pontok.Content = "Pontok: " + pont;
            }
            else
                hiba.Text = "Hiba: Nem lehet kevesebb mint 0 pontod.";
        }
        private void intl1_Click(object sender, RoutedEventArgs e)
        {
            if (intl > 1)
            {
                intl--;
                intlL.Content = "Intelligencia: " + intl;
                pont++;
                pontok.Content = "Pontok: " + pont;
            }
            else
                hiba.Text = "Hiba: Nem lehet 1 alá venni a statjaidat.";
        }
        private void intl2_Click(object sender, RoutedEventArgs e)
        {
            if (pont > 0)
            {
                intl++;
                intlL.Content = "Intelligencia: " + intl;
                pont--;
                pontok.Content = "Pontok: " + pont;
            }
            else
                hiba.Text = "Hiba: Nem lehet kevesebb mint 0 pontod.";
        }

        private void nev_TextChanged(object sender, TextChangedEventArgs e)
        {
            knev = nev.Text;
        }

        private void ujkarakter_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(pontok.Content) == "Pontok: 0")
            {
                if (nev.Text == "")
                {
                    hiba.Text = "Hiba: El kell nevezned a rókádat!";
                }
                else
                {
                    StreamReader klassz = new StreamReader("klassz.txt");
                    string klasz = klassz.ReadLine();
                    StreamWriter swnev = new StreamWriter("nev.txt");
                    swnev.WriteLine(knev);
                    StreamWriter karakter = new StreamWriter(knev + ".txt");
                    karakter.WriteLine(knev + "\n" + ero + "\n" + ved + "\n" + moz + "\n" + intl + "\n" + klasz);
                    klassz.Close();
                    swnev.Close();
                    karakter.Close();
                    MainWindow subWindow = new MainWindow();
                    subWindow.Show();
                    Window2.Close();
                }
            }
            else
            {
                hiba.Text = "Hiba: El kell költened a pontjaidat!";
            }
        }

    }
}

