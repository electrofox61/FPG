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

namespace FPG
{
    /// <summary>
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            leiras.Content = "Harcos:\n - Védekezés: 10 védekezést és 5 dühöt kapsz \n - Sima támadás: 10-et sebez és 20 dühöt kapsz\n - Lefejelés: 20-at sebez és 30 dühbe kerül\n - Rókapörgés: 50-et sebez és 60 dühbe kerül";
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            leiras.Content = "Mágus:\n - Körönként kap 10 manát \n - Buborék: 5 manába kerül, 10 védekezést kapsz\n - Tűzgolyó: 15 manába kerül, 10-et sebez, égő effektet ad az ellenfélre, körönként 5 - öket sebez 2 körig\n - Jégcsap: 15 manába kerül, 10-et sebez, ha tűz effekt volt rajta akkor az égést megállítja, és helyette \n +10 sebzést kap \n - Robbanás: 40 manába kerül, 60-at sebez.";
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            leiras.Content = "Druida:\n - Körönként kap 10 manát \n - Teknőspáncél: 10 védekezést kapsz\n - Karmolás: 10-et sebez\n - Gyökércsapda: 20 manába kerül, 10-et sebez, és 'lezárja' az ellenfelet, így nem tud támadni egy körben.\n - Élet növénye: 30 manába kerül, és 15 Hp-t gyógyít.";
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            leiras.Content = "Erő: Az erő összege hozzáadódik a sebzésedhez. Az erő nem adódik hozzá az égéshez, és adódik hozzá\n 0-hoz (avagy nem fogsz sebezni, amikor védekezel)";
        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            leiras.Content = "Védelem: A védelem összege kivonódik a hp-ból amit veszítenél. Ez összeadódóan működik a védekezéssel,\n avagy elméletben lehetséges halhatatlannak lenni, ha elég szintkülönbség van a két karakter között (a\n szintekről máshol van írva)";
        }

        private void ListBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            leiras.Content = "Mozgékonyság: A mozgékonyság egy esélyt ad arra hogy egyáltalán ne sebződj egy körben. Minél nagyobb\n a mozgékonyság, annál nagyobb az esélyed hogy kikerüld az ellenfél támadását.";
        }

        private void ListBoxItem_Selected_6(object sender, RoutedEventArgs e)
        {
            leiras.Content = "Intelligencia: A körönként kapott manádhoz/dühödhöz adódik hozzá.";
        }

        private void ListBoxItem_Selected_7(object sender, RoutedEventArgs e)
        {
            leiras.Content = "Szintek: Minden harc xp-t ad, mindkét félnek. A nyertes 1000 xp-t kap, míg a vesztes 500-at. Minden\n 1000 xp megszerzése után szintet lép a karakter, ami 1 pontot ad egy véletlenszerűen kiválasztott\n statodba. Ez lehet erő, védelem, mozgékonyság, vagy intelligencia. A karakterek közötti szintkülönbségek\n nagyon fontosak tudnak lenni, akár annyira hogy lehetetlen legyen a kisebb szintűnek a harc.";
        }

        private void ListBoxItem_Selected_8(object sender, RoutedEventArgs e)
        {
            leiras.Content = "Harc:\n - A harc kezdete előtt be kell írnod a két karakter nevét, majd a Tovább gombra kell nyomni. \n - A harc kezdetekor több dolog is megjelenik/megváltozik. Észreveheted a Hp és Düh/Mana értékeket.\n 4 gomb jelenik meg, karaktertől függően. Miután megnyomtad az ellenfél köre jön, ő is kiválasztja hogy\n támad, védekezik stb. Ezután újra a te köröd lesz. Ez addig megy amíg valamelyikőtöknek a Hp-ja\n el nem éri a 0-át. Ilyenkor az egyikőtök a győztes lesz, és az xp-t megkapjátok a megfelelő formában.\n Ezután a Tovább gombbal visszakerülsz a játék elejére.";
        }

        private void ListBoxItem_Selected_9(object sender, RoutedEventArgs e)
        {
            leiras.Content = "Karakternézegető: A karakternézegetőben tudod megnézni a karaktereid statjait, szintjeit. Egyszerűen\n beírod a nevét a karakternek, majd rányomsz a 'keresés' gombra.";
        }
        private void ListBoxItem_Selected_10(object sender, RoutedEventArgs e)
        {
            leiras.Content = "Karakterkészítés:\n - Elsőnek a karaktered klasszját kell kiválasztanod. Egyelőre csak a Harcos, Mágus,\n és Druida közül lehet választani. \n - Következőnek a nevet kell megadnod és a statokat kell elosztanod. Név nélküli karakter nem lehet.\n Minden képesség 1-ről indul és az alá nem mehet. 10 pontod van amit tudsz osztogatni a képességek\n között. Miután készen vagy rányomhatsz a 'Tovább' gombra, hogy elkezdj egy harcot, vagy csinálhatsz egy\n másik karaktert.";
        }
    }
}
