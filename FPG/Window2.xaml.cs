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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        string karakter = "";
        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            tovabb.IsEnabled = true;
            karakterleiras.Content = "Harcos:\n - Védekezés: 10 védekezést és 5 dühöt kapsz \n - Sima támadás: 10 - et sebez és 20 dühöt kapsz\n - Lefejelés: 20 - at sebez és 30 dühbe kerül\n - Rókapörgés: 50 - et sebez és 60 dühbe kerül";;
            karakter = "Harcos";
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            tovabb.IsEnabled = true;
            karakterleiras.Content = "Mágus:\n - Körönként kap 10 manát \n - Buborék: 5 manába kerül, 10 védekezést kapsz\n - Tűzgolyó: 15 manába kerül, 10-et sebez, égő effektet ad\n az ellenfélre, körönként 5 - öket sebez 2 körig\n - Jégcsap: 15 manába kerül, 10-et sebez, ha tűz effekt volt\n rajta akkor az égést megállítja, és helyette +10 sebzést\n kap \n - Robbanás: 40 manába kerül, 60-at sebez.";
            karakter = "Mágus";
        }
        
        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            tovabb.IsEnabled = true;
            karakterleiras.Content = "Íjász:";
            karakter = "Íjász";
        }
        
        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            tovabb.IsEnabled = true;
            karakterleiras.Content = "Druida:\n - Körönként kap 10 manát \n - Teknőspáncél: 10 védekezést kapsz\n - Karmolás: 10-et sebez\n - Gyökércsapda: 20 manába kerül, 10-et sebez, és 'lezárja'\n az ellenfelet, így nem tud támadni egy körben.\n - Élet növénye: 30 manába kerül, és 15 Hp-t gyógyít.";
            karakter = "Druida";
        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            tovabb.IsEnabled = true;
            karakterleiras.Content = "Lövész:";
            karakter = "Lövész";
        }

        private void ListBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            tovabb.IsEnabled = true;
            karakterleiras.Content = "Alkimista:";
            karakter = "Alkimista";
        }

        private void tovabb_Click(object sender, RoutedEventArgs e)
        {
                StreamWriter klassz = new StreamWriter("klassz.txt");
                klassz.WriteLine(karakter);
                klassz.Close();
                Window1 subWindow = new Window1();
                subWindow.Show();
                Window1.Close();
        }
    }
}
