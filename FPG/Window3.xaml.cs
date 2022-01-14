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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        //A legtöbb változót itt adom meg, hogy tudjam milyen változók léteznek és ne legyen azzal baj hogy egy class-on belül adom meg és nem érem el. Nem feltétlen optimális ugye ez, de itt annyira nem számít.
        //Csoportokra vannak szedve valamennyire a változók, de nem feltétlen egyértelmű ránézésre

        //Point eger;
        string nev, ellnev;
        int ero, ved, moz, intl, xp, eero, eved, emoz, eintl, exp;
        int hp = 200, ellhp = 200;
        int duh, mana, eduh, emana;
        bool harcvege = false;
        int eges, eeges;
        int root, eroot;
        int ihp, eihp, ixp, iexp, imana, iemana, iduh, ieduh;
        int veletlen;
        //int i = 0;
        int sebzes, esebzes, pmanaduh, epmanaduh = 0;
        int dodge, dodger, edodge, edodger;
        bool dodged = false, edodged = false;
        int szandek;
        string klassz, eklassz;

        List<string> parbeszed = new List<string>();
        public Window3()
        {
            InitializeComponent();
        }
        public void Gombtuntetes()
        {
            //Eltüntetjük a harchoz szükséges dolgokat
            vedekezes.Visibility = Visibility.Collapsed;
            vedekezes.Visibility = Visibility.Collapsed;
            tamadas.Visibility = Visibility.Collapsed;
            mtamadas.Visibility = Visibility.Collapsed;
            htamadas.Visibility = Visibility.Collapsed;
            hpT.Visibility = Visibility.Collapsed;
            ellhpT.Visibility = Visibility.Collapsed;
            manaduh.Visibility = Visibility.Collapsed;
            emanaduh.Visibility = Visibility.Collapsed;
        }
        public void GyozelemVereseg()
        {
            //Megnézzük hogy nyert-e valaki, előbb azt hogy a játékos nyert-e, így döntetlennél a játékos nyer
            if (ellhp <= 0) //ha a játékos nyert
            {
                
                Gombtuntetes();
                emhp.Visibility = Visibility.Collapsed;
                mhp.Visibility = Visibility.Collapsed;
                mmanaduh.Visibility = Visibility.Collapsed;
                emmanaduh.Visibility = Visibility.Collapsed;
                parbeszedT.Text = "\t \t Győzelem! :)";
                tovabb.IsEnabled = true;
                tovabb.Visibility = Visibility.Visible;
                harcvege = true;
                ellhpT.Text = "Hp:0/200";
                ixp = xp;
                iexp = exp;
                xp += 1000;
                exp += 500;
                if (xp - ixp >= 1000) //szintett lépett-e a játékos
                {
                    szintl.Text = nev + " szintet lépett!";
                    Random r = new Random();
                    veletlen = r.Next(1, 5);
                    switch (veletlen)
                    {
                        case 1:
                            ero += 1;
                            break;
                        case 2:
                            ved += 1;
                            break;
                        case 3:
                            moz += 1;
                            break;
                        case 4:
                            intl += 1;
                            break;
                    }
                }
                if (exp - iexp >= 1000) //szintett lépett-e az ellenfél
                {
                    eszintl.Text = ellnev + " szintet lépett!";
                    Random r = new Random();
                    veletlen = r.Next(1, 5);
                    switch (veletlen)
                    {
                        case 1:
                            eero += 1;
                            break;
                        case 2:
                            eved += 1;
                            break;
                        case 3:
                            emoz += 1;
                            break;
                        case 4:
                            eintl += 1;
                            break;
                    }
                }
                StreamWriter stat = new StreamWriter(nev + ".txt");
                stat.WriteLine(nev);
                stat.WriteLine(Convert.ToInt32(ero));
                stat.WriteLine(Convert.ToInt32(ved));
                stat.WriteLine(Convert.ToInt32(moz));
                stat.WriteLine(Convert.ToInt32(intl));
                stat.WriteLine(klassz);
                stat.WriteLine(Convert.ToInt32(xp));
                stat.Close();
                StreamWriter estat = new StreamWriter(ellnev + ".txt");
                estat.WriteLine(ellnev);
                estat.WriteLine(Convert.ToInt32(eero));
                estat.WriteLine(Convert.ToInt32(eved));
                estat.WriteLine(Convert.ToInt32(emoz));
                estat.WriteLine(Convert.ToInt32(eintl));
                estat.WriteLine(eklassz);
                estat.WriteLine(Convert.ToInt32(exp));
                estat.Close();
            }
            else if (hp <= 0)   //ha az ellenfél nyert
            {
                
                Gombtuntetes();
                emhp.Visibility = Visibility.Collapsed;
                mhp.Visibility = Visibility.Collapsed;
                mmanaduh.Visibility = Visibility.Collapsed;
                emmanaduh.Visibility = Visibility.Collapsed;
                parbeszedT.Text = "\t \t Vereség! :(";
                tovabb.IsEnabled = true;
                tovabb.Visibility = Visibility.Visible;
                harcvege = true;
                hpT.Text = "Hp:0/200";
                ixp = xp;
                iexp = exp;
                xp += 500;
                exp += 1000;
                if (xp - ixp >= 1000)
                {
                    szintl.Text = nev + " szintet lépett!";
                    Random r = new Random();
                    veletlen = r.Next(1, 5);
                    switch (veletlen)
                    {
                        case 1:
                            ero += 1;
                            break;
                        case 2:
                            ved += 1;
                            break;
                        case 3:
                            moz += 1;
                            break;
                        case 4:
                            intl += 1;
                            break;
                    }
                }
                if (exp - iexp >= 1000)
                {
                    eszintl.Text = ellnev + " szintet lépett!";
                    Random r = new Random();
                    veletlen = r.Next(1, 5);
                    switch (veletlen)
                    {
                        case 1:
                            eero += 1;
                            break;
                        case 2:
                            eved += 1;
                            break;
                        case 3:
                            emoz += 1;
                            break;
                        case 4:
                            eintl += 1;
                            break;
                    }
                }
                StreamWriter stat = new StreamWriter(nev + ".txt");
                StreamWriter estat = new StreamWriter(ellnev + ".txt");
                stat.WriteLine(nev);
                stat.WriteLine(Convert.ToInt32(ero));
                stat.WriteLine(Convert.ToInt32(ved));
                stat.WriteLine(Convert.ToInt32(moz));
                stat.WriteLine(Convert.ToInt32(intl));
                stat.WriteLine(klassz);
                stat.WriteLine(Convert.ToInt32(xp));
                estat.WriteLine(ellnev);
                estat.WriteLine(Convert.ToInt32(eero));
                estat.WriteLine(Convert.ToInt32(eved));
                estat.WriteLine(Convert.ToInt32(emoz));
                estat.WriteLine(Convert.ToInt32(eintl));
                estat.WriteLine(eklassz);
                estat.WriteLine(Convert.ToInt32(exp));
                stat.Close();
                estat.Close();
            }
        }
        public void manaduhteszt()
        {
            //ellenőrizzük hogy nem megy a mana vagy a düh 100 felé
            if (duh > 100)
            {
                duh = 100;
            }
            else if (mana > 100)
            {
                mana = 100;
            }
            if (eduh > 100)
            {
                eduh = 100;
            }
            else if (emana > 100)
            {
                emana = 100;
            }
        }
        public bool mozgszam()
        {
            //a mozgékonyság alapján van esélyed hogy "dodgeolod" az ellenfél képességét, ezzel a rendszerrel annyi baj lehet, hogy túl nagy szint esetén 100% a dodge chance
            Random r = new Random();
            dodger = r.Next(0, 201);
            dodge = moz * 10;
            if (dodge > dodger)
            {
                dodged = true;
                mhp.Text = "dodged";
            }
            else
            {
                dodged = false;
            }
            return dodged;
        }
        public bool emozgszam()
        {
            //A dodgeolás, csak az ellenfélnél
            Random r = new Random();
            edodger = r.Next(0, 201);
            edodge = emoz * 10;
            if (edodge > edodger)
            {
                edodged = true;
                emhp.Text = "dodged";
            }
            else
            {
                edodged = false;
            }
            return edodged;
        }
        public void kepek()
        {
            //Beillesztjük a megfelelő képeket karakter szerint
            statolvasas();
            switch (klassz)
            {
                case "Harcos":
                    player.Source = new BitmapImage(new Uri("FoxyWarrior.png", UriKind.Relative));
                    break;
                case "Mágus":
                    player.Source = new BitmapImage(new Uri("FoxyMage.png", UriKind.Relative));
                    break;
                case "Íjász":
                    break;
                case "Druida":
                    player.Source = new BitmapImage(new Uri("FoxyDruid.png", UriKind.Relative));
                    break;
            }
            switch (eklassz)
            {
                case "Harcos":
                    ellenfelk.Source = new BitmapImage(new Uri("WolfWarrior.png", UriKind.Relative));
                    break;
                case "Mágus":
                    ellenfelk.Source = new BitmapImage(new Uri("WolfMage.png", UriKind.Relative));
                    break;
                case "Íjász":
                    break;
                case "Druida":
                    ellenfelk.Source = new BitmapImage(new Uri("WolfDruid.png", UriKind.Relative));
                    break;
            }
        }
        public void vedekezni()
        {
            //ellenfél védekezés esetén sebződés
            emozgszam();
            if (edodged == false)
            {
                eihp = ellhp;
                ellhp -= sebzes - eved;
                ellhp += 10;
                if (ellhp > eihp)
                {
                    ellhp = eihp;
                }
                if (eihp - ellhp > 0)
                {
                    emhp.Text = $"-{eihp - ellhp}hp";
                }
                else
                {
                    emhp.Text = $"+{Math.Abs(eihp - ellhp)}hp";
                }
            }
            ellhpT.Text = "Hp:" + ellhp + "/200";
        }
        public void ellsebzodes()
        {
            //ellenfél sebződésének kiszámolása
            emozgszam();
            if (edodged == false)
            {
                eihp = ellhp;
                ellhp -= sebzes - eved;
                if (ellhp > eihp)
                {
                    ellhp = eihp;
                }
                if (eihp - ellhp > 0)
                {
                    emhp.Text = $"-{eihp - ellhp}hp";
                }
                else
                {
                    emhp.Text = $"+{Math.Abs(eihp - ellhp)}hp";
                }
            }
        }
        public void sebzodes()
        {
            //Játékos sebződésének kiszámítása
            mozgszam();
            if (dodged == false)
            {
                ihp = hp;
                hp -= esebzes + eero - ved;
                if (hp > ihp)
                {
                    hp = ihp;
                }
                if (ihp - hp > 0)
                {
                    mhp.Text = $"-{ihp - hp}hp";
                }
                else
                {
                    mhp.Text = $"+{Math.Abs(ihp - hp)}hp";
                }
            }
            if (eeges > 0)
            {
                ihp = hp;
                hp -= 10 - ved;
                if (hp > ihp)
                {
                    hp = ihp;
                }
            }
        }
        public void duhvaltozas()
        {
            //A játékos dühének változása
            iduh = duh;
            duh += pmanaduh + intl;
            manaduhteszt();
            if (iduh - duh > 0)
            {
                mmanaduh.Text = $"-{iduh - duh}düh";
            }
            else
            {
                mmanaduh.Text = $"+{Math.Abs(iduh - duh)}düh";
            }
        }
        public void eduhvaltozas()
        {
            //Az ellenfél dühének változása
            ieduh = eduh;
            eduh += epmanaduh + eintl;
            manaduhteszt();
            if (ieduh - eduh > 0)
            {
                emmanaduh.Text = $"-{ieduh - eduh}düh";
            }
            else
            {
                emmanaduh.Text = $"+{Math.Abs(ieduh - eduh)}düh";
            }
        }
        public void manavaltozas()
        {
            //A játékos manájának változása
            imana = mana;
            mana += pmanaduh + intl;
            manaduhteszt();
            if (imana - mana > 0)
            {
                mmanaduh.Text = $"-{imana - mana}mana";
            }
            else
            {
                mmanaduh.Text = $"+{Math.Abs(imana - mana)}mana";
            }
        }
        public void emanavaltozas()
        {
            //Az ellenfél manájának változása
            iemana = emana;
            emana += epmanaduh + eintl;
            manaduhteszt();
            if (iemana - emana > 0)
            {
                emmanaduh.Text = $"-{iemana - emana}mana";
            }
            else
            {
                emmanaduh.Text = $"+{Math.Abs(iemana - emana)}mana";
            }
        }
        public void ellenfel()
        {
            // Ez az egész az ellenfél támadásai, viszont itt van kiszámolva a legtöbb dolog, mint a játékos és az ellenfél sebződése
            
            //Ez mondja meg mit fog csinálni az ellenfél. Kicsit érdekesen néz ki, főleg mivel StackOverFlow hibákat kaptam, így át kellett írnom hogy ne tudja újra és újra kiválasztani a manás támadásokat ha nincs manája. (még mindig lenne egyszerűbb megoldás)
            if (Convert.ToString(szandek1.Content) == "")
            {
                Random r = new Random();
                szandek = r.Next(1, 5);
            }
            else
            {
                szandek = Convert.ToInt32(szandek1.Content);
                szandek1.Content = "";
            }
            //Az ellenfél támadásai, a legtöbb része el van magyarázva máshol
            switch (szandek)
            {
                case 1: //vedekezes
                    switch (eklassz)
                    {
                        case "Harcos":
                            intention.Text = "Védekezés"; //Elmondja mit csinált az ellenfél
                            vedekezni();
                            epmanaduh = 5; //Érték a düh/manaváltozáshoz
                            eduhvaltozas();
                            emanaduh.Text = "Düh:" + eduh + "/100"; //A mana frissítése a képernyőn
                            GyozelemVereseg();
                            break; //Végrement egy támadás, nem kell tovább folytatni
                        case "Mágus":
                            intention.Text = "Buborék";
                            emozgszam();
                            vedekezni();
                            epmanaduh = 5;
                            emanavaltozas();
                            emanaduh.Text = "Mana:" + emana + "/100";
                            GyozelemVereseg();
                            break;
                        case "Íjász":
                            break;
                        case "Druida":
                            if (root == 0)
                            {
                                intention.Text = "Teknőspáncél";
                                vedekezni();
                                epmanaduh = 10;
                                emanavaltozas();
                                hpT.Text = "Hp:" + hp + "/200";
                                emanaduh.Text = "Mana:" + emana + "/100";
                                GyozelemVereseg();
                            }
                            else
                            {
                                root -= 1;
                                intention.Text = "Teknőspáncél";
                                vedekezni();
                                epmanaduh = 10;
                                emanavaltozas();
                                hpT.Text = "Hp:" + hp + "/200";
                                emanaduh.Text = "Mana:" + emana + "/100";
                                GyozelemVereseg();
                            }
                            break;
                    }
                    break;
                case 2: //tamadas
                    switch (eklassz)
                    {
                        case "Harcos":
                            intention.Text = "Sima Támadás";
                            ellsebzodes();
                            ellhpT.Text = "Hp:" + ellhp + "/200";
                            esebzes = 10;
                            sebzodes();
                            hpT.Text = "Hp:" + hp + "/200";
                            epmanaduh = 20;
                            eduhvaltozas();
                            emanaduh.Text = "Düh:" + eduh + "/100";
                            GyozelemVereseg();
                            break;
                        case "Mágus":
                            if (emana >= 15)
                            {
                                intention.Text = "Tűzgolyó";
                                ellsebzodes();
                                ellhpT.Text = "Hp:" + ellhp + "/200";
                                esebzes = 10;
                                sebzodes();
                                hpT.Text = "Hp:" + hp + "/200";
                                eeges += 2;
                                epmanaduh = -5;
                                emanavaltozas();
                                emanaduh.Text = "Mana:" + emana + "/100";
                                GyozelemVereseg();
                            }
                            else
                            {
                                Random r = new Random();
                                szandek1.Content = r.Next(1, 2);
                                ellenfel();
                            }
                            break;
                        case "Íjász":
                            break;
                        case "Druida":
                            if (root == 0)
                            {
                                intention.Text = "Karmolás";
                                ellsebzodes();
                                ellhpT.Text = "Hp:" + ellhp + "/200";
                                esebzes = 10;
                                sebzodes();
                                hpT.Text = "Hp:" + hp + "/200";
                                epmanaduh = 10;
                                emanavaltozas();
                                emanaduh.Text = "Mana:" + emana + "/100";
                                GyozelemVereseg();
                            }
                            else
                            {
                                root -= 1;
                                intention.Text = "Karmolás";
                                ellsebzodes();
                                ellhpT.Text = "Hp:" + ellhp + "/200";
                                epmanaduh = 10;
                                emanavaltozas();
                                emanaduh.Text = "Mana:" + emana + "/100";
                                GyozelemVereseg();
                            }
                            break;
                    }
                    break;
                case 3: //mtamadas
                    switch (eklassz)
                    {
                        case "Harcos":
                            intention.Text = "Lefejelés";
                            if (eduh >= 30)
                            {
                                ellsebzodes();
                                ellhpT.Text = "Hp:" + ellhp + "/200";
                                esebzes = 20;
                                sebzodes();
                                hpT.Text = "Hp:" + hp + "/200";
                                epmanaduh = -30;
                                emanavaltozas();
                                emanaduh.Text = "Düh:" + eduh + "/100";
                                GyozelemVereseg();
                            }
                            else
                            {
                                Random r = new Random();
                                szandek1.Content = r.Next(1, 2);
                                ellenfel();
                            }
                            break;
                        case "Mágus":
                            if (emana >= 15)
                            {
                                intention.Text = "Jégcsap";
                                ellsebzodes();
                                ellhpT.Text = "Hp:" + ellhp + "/200";
                                eeges += 2;
                                esebzes = 10;
                                sebzodes();
                                hpT.Text = "Hp:" + hp + "/200";
                                epmanaduh = -5;
                                emanavaltozas();
                                emanaduh.Text = "Mana:" + emana + "/100";
                                GyozelemVereseg();
                            }
                            else
                            {
                                Random r = new Random();
                                szandek1.Content = r.Next(1, 3);
                                ellenfel();
                            }
                            break;
                        case "Íjász":
                            break;
                        case "Druida":
                            if (emana >= 20)
                            {
                                if (root == 0)
                                {
                                    intention.Text = "Gyökércsapda";
                                    ellsebzodes();
                                    ellhpT.Text = "Hp:" + ellhp + "/200";
                                    esebzes = 10;
                                    sebzodes();
                                    hpT.Text = "Hp:" + hp + "/200";
                                    eroot += 1;
                                    epmanaduh = -10;
                                    emanavaltozas();
                                    emanaduh.Text = "Mana:" + emana + "/100";
                                    GyozelemVereseg();
                                }
                                else
                                {
                                    root -= 1;
                                    intention.Text = "Gyökércsapda";
                                    ellsebzodes();
                                    ellhpT.Text = "Hp:" + ellhp + "/200";
                                    epmanaduh = 10;
                                    emanavaltozas();
                                    emanaduh.Text = "Mana:" + emana + "/100";
                                    GyozelemVereseg();
                                }
                            }
                            else
                            {
                                Random r = new Random();
                                szandek1.Content = r.Next(1, 3);
                                ellenfel();
                            }
                            break;
                    }
                    break;
                case 4: //htamadas
                    switch (eklassz)
                    {
                        case "Harcos":
                            intention.Text = "Rókapörgés";
                            if (eduh >= 60)
                            {
                                ellsebzodes();
                                ellhpT.Text = "Hp:" + ellhp + "/200";
                                esebzes = 40;
                                sebzodes();
                                hpT.Text = "Hp:" + hp + "/200";
                                epmanaduh = -60;
                                emanavaltozas();
                                emanaduh.Text = "Düh:" + eduh + "/100";
                                GyozelemVereseg();
                            }
                            else
                            {
                                Random r = new Random();
                                szandek1.Content = r.Next(1,3);
                                ellenfel();
                            }
                            break;
                        case "Mágus":
                            if (emana >= 40)
                            {
                                intention.Text = "Robbanás";
                                ellsebzodes();
                                ellhpT.Text = "Hp:" + ellhp + "/200";
                                esebzes = 10;
                                sebzodes();
                                hpT.Text = "Hp:" + hp + "/200";
                                epmanaduh = -30;
                                emanavaltozas();
                                emanaduh.Text = "Mana:" + emana + "/100";
                                GyozelemVereseg();
                            }
                            else
                            {
                                Random r = new Random();
                                szandek1.Content = r.Next(1, 2);
                                ellenfel();
                            }
                            break;
                        case "Íjász":
                            break;
                        case "Druida":
                            if (emana >= 30)
                            {
                                if (root == 0)
                                {
                                    intention.Text = "Élet növénye";
                                    ellsebzodes();
                                    ellhp += 15;
                                    ellhpT.Text = "Hp:" + ellhp + "/200";
                                    epmanaduh = -20;
                                    emanavaltozas();
                                    emanaduh.Text = "Mana:" + emana + "/100";
                                    GyozelemVereseg();
                                }
                                else
                                {
                                    root -= 1;
                                    intention.Text = "Élet növénye";
                                    ellsebzodes();
                                    ellhpT.Text = "Hp:" + ellhp + "/200";
                                    epmanaduh = 10;
                                    emanavaltozas();
                                    emanaduh.Text = "Mana:" + emana + "/100";
                                    GyozelemVereseg();
                                }
                            }
                            else
                            {
                                Random r = new Random();
                                szandek1.Content = r.Next(1, 3);
                                ellenfel();
                            }
                            break;
                    }
                    break;
            }
        }
        public void nevparbeszed()
        {
            //Ez menne át a névadásról a párbeszédre, mivel kivettem a párbeszédet (pontosabban meg se csináltam jól) így egyből a harc miatt kell ezeket eltüntetni
            playernev.Visibility = Visibility.Collapsed;
            ellenfelnev.Visibility = Visibility.Collapsed;
            playernev1.Visibility = Visibility.Collapsed;
            ellenfelnev1.Visibility = Visibility.Collapsed;
            parbeszedT.Visibility = Visibility.Visible;
        }
        public void statolvasas()
        {
            //A két karakter statjainak beolvasása
            StreamReader stats = new StreamReader(nev + ".txt");
            nev = stats.ReadLine();
            ero = Convert.ToInt32(stats.ReadLine());
            ved = Convert.ToInt32(stats.ReadLine());
            moz = Convert.ToInt32(stats.ReadLine());
            intl = Convert.ToInt32(stats.ReadLine());
            klassz = stats.ReadLine() ;
            xp = Convert.ToInt32(stats.ReadLine());
            stats.Close();
            StreamReader estat = new StreamReader(ellnev + ".txt");
            ellnev = estat.ReadLine();
            eero = Convert.ToInt32(estat.ReadLine());
            eved = Convert.ToInt32(estat.ReadLine());
            emoz = Convert.ToInt32(estat.ReadLine());
            eintl = Convert.ToInt32(estat.ReadLine());
            eklassz = estat.ReadLine();
            exp = Convert.ToInt32(estat.ReadLine());
            estat.Close();
        }
        public void harckezdet()
        {
            //Tovább gombot "eltüntetjük", a többit megidézzük
            tovabb.IsEnabled = false;
            tovabb.Visibility = Visibility.Collapsed;
            vedekezes.Visibility = Visibility.Visible;
            tamadas.Visibility = Visibility.Visible;
            mtamadas.Visibility = Visibility.Visible;
            htamadas.Visibility = Visibility.Visible;
            hpT.Visibility = Visibility.Visible;
            ellhpT.Visibility = Visibility.Visible;
            manaduh.Visibility = Visibility.Visible;
            emanaduh.Visibility = Visibility.Visible;
            //A hpk értékét megadjuk
            hpT.Text = "Hp: 200/200";
            ellhpT.Text = "Hp: 200/200";
            //Minden karakternek saját gombneveket állítunk, megállapítjuk hogy mana kell vagy düh, és ToolTip-et állítunk
            statolvasas();
            switch (klassz)
            {
                case "Harcos":
                    manaduh.Text = "Düh:0/100";
                    vedekezes.ToolTip = "10 védekezést és 5 dühöt kapsz";
                    tamadas.ToolTip = "10-et sebez és 20 dühöt kapsz";
                    mtamadas.ToolTip = "20-at sebez és 30 dühbe kerül";
                    htamadas.ToolTip = "50-et sebez és 60 dühbe kerül";
                    break;
                case "Mágus":
                    manaduh.Text = "Mana:0/100";
                    vedekezes.Content = "Buborék";
                    tamadas.Content = "Tűzgolyó";
                    mtamadas.Content = "Jégcsap";
                    htamadas.Content = "Robbanás";
                    vedekezes.ToolTip = "5 manába kerül, 10 védekezést kapsz";
                    tamadas.ToolTip = "15 manába kerül, 10-et sebez, égő effektet ad az ellenfélre, körönként 5 - öket sebez 2 körig";
                    mtamadas.ToolTip = "5 manába kerül, 10-et sebez, ha tűz effekt volt rajta akkor az égést megállítja, és helyette +10 sebzést kap";
                    htamadas.ToolTip = "40 manába kerül, 60-at sebez";
                    break;
                case "Íjász":
                    break;
                case "Druida":
                    manaduh.Text = "Mana:0/100";
                    vedekezes.Content = "Teknőspáncél";
                    tamadas.Content = "Karmolás";
                    mtamadas.Content = "Gyökércsapda";
                    htamadas.Content = "Élet növénye";
                    vedekezes.ToolTip = "10 védekezést kapsz";
                    tamadas.ToolTip = "10-et sebez";
                    mtamadas.ToolTip = "20 manába kerül, 10-et sebez, és 'lezárja' az ellenfelet, így nem tud támadni egy körben";
                    htamadas.ToolTip = "30 manába kerül, és 15 Hp-t gyógyít";
                    break;
            }
            switch (eklassz)
            {
                case "Harcos":
                    emanaduh.Text = "Düh:0/100";
                    break;
                case "Mágus":
                    emanaduh.Text = "Mana:0/100";
                    break;
                case "Druida":
                    emanaduh.Text = "Mana:0/100";
                    break;
            }
        }
        private void Window1_Activated(object sender, EventArgs e)
        {
            //A gombok "eltüntetése", csak azért nem alapból "tűnnek el" hogy a szerkesztőben láthatóak legyenek
            Gombtuntetes();
            parbeszedT.Visibility = Visibility.Collapsed;
        }
        private void playernev1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Játékosnév megadása
            nev = playernev1.Text;
            pnev.Text = playernev1.Text;
        }
        private void ellenfelnev1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Ellenfélnév megadása
            ellnev = ellenfelnev1.Text;
            enev.Text = ellenfelnev1.Text;
        }
        private void tovabb_Click(object sender, RoutedEventArgs e)
        {
            //Van itt olyan amit kivettem, de még jegyzetben van
            //Több dolgot csinál, elsőnek is tovább megy a karaktermegadásból
            if (nev == "" || ellnev == "")
            {
                hibaT.Text = "Hiba: meg kell adnod a neveiket a karaktereknek!!";
            }
            else 
            {
                try
                {
                    hibaT.Text = "Hiba:";
                    //if (i < 1)
                    //{
                        
                    kepek();
                    nevparbeszed();
                    //}
                    if (harcvege == true) //ha vége van a harcnak akkor bezárja és behozza a főmenüt
                    {
                        MainWindow subWindow = new MainWindow();
                        subWindow.Show();
                        Window1.Close();
                    }
                    //A párbeszéd beolvasása
                    /*StreamReader parbeszedo = new StreamReader("parbeszed.txt");
                    while (!parbeszedo.EndOfStream)
                    {
                        string sor = parbeszedo.ReadLine();
                        parbeszed.Add(sor);
                    }
                    parbeszedo.Close();
                    parbeszedT.Text = "" + parbeszed[i];
                    i++;*/
                    //3 Párbeszéd után elkezdődik a harc
                    //if (i > 4)
                    //{
                    harckezdet();
                    //}
                }
                catch (FileNotFoundException) //Azért van ugye hogy csak létező karaktert lehessen megadni, viszont vettem már olyat észre hogy nem működik elsőre és továbbmegy valamiért
                {
                    hibaT.Text = "Hiba: nincs ilyen karakter!";
                }
            }
        }
        private void vedekezes_Click(object sender, RoutedEventArgs e)
        {
            
            switch (klassz)
            {
                case "Harcos":
                    pmanaduh = 5;
                    duhvaltozas();
                    manaduh.Text = "Düh:" + duh + "/100";
                    sebzes = 0;
                    GyozelemVereseg();
                    ellenfel();
                    break;
                case "Mágus":
                    pmanaduh = 5;
                    manavaltozas();
                    manaduh.Text = "Mana:" + mana + "/100";
                    sebzes = 0;
                    GyozelemVereseg();
                    ellenfel();
                    break;
                case "Íjász":
                    break;
                case "Druida":
                    if (eroot == 0)
                    {
                        pmanaduh = 5;
                        manavaltozas();
                        manaduh.Text = "Mana:" + mana + "/100";
                        sebzes = 0;
                        GyozelemVereseg();
                        ellenfel();
                    }
                    else
                    {
                        eroot -= 1;
                        ellenfel();
                    }
                    break;
            }
        }
        private void tamadas_Click(object sender, RoutedEventArgs e)
        {
            
            if (klassz=="Harcos")
            {
                sebzes = 10 + ero;
                pmanaduh = 20;
                duhvaltozas();
                manaduh.Text = "Düh:" + duh + "/100";
                GyozelemVereseg();
                ellenfel();
            }
            if (klassz == "Mágus" && mana >= 15)
            {
                sebzes = 10 + ero;
                eges += 2;
                if (eges > 0)
                {
                    sebzes += 5;
                    eges -= 1;
                }
                pmanaduh = -5;
                manavaltozas();
                manaduh.Text = "Mana:" + mana + "/100";
                GyozelemVereseg();
                ellenfel();
            }
            if (klassz == "Druida")
            {
                if (eroot == 0)
                {
                    sebzes = 10 + ero;
                    pmanaduh = 10;
                    manavaltozas();
                    manaduh.Text = "Mana:" + mana + "/100";
                    GyozelemVereseg();
                    ellenfel();
                }
                else
                {
                    eroot -= 1;
                    ellenfel();
                }
            }
        }
        private void mtamadas_Click(object sender, RoutedEventArgs e)
        {
            
            if (klassz == "Harcos" && duh >= 30)
            {
                sebzes = 20 + ero;
                pmanaduh = -30;
                duhvaltozas();
                manaduh.Text = "Düh:" + duh + "/100";
                GyozelemVereseg();
                ellenfel();
            }
            if (klassz == "Mágus" && mana >= 15)
            {
                sebzes = 10 + ero;
                pmanaduh = -5;
                manavaltozas();
                if (eges > 0)
                {
                    eges = 0;
                    sebzes += 10;
                }
                manaduh.Text = "Mana:" + mana + "/100";
                GyozelemVereseg();
                ellenfel();
            }
            if (klassz == "Druida" && mana >= 20)
            {
                if (eroot == 0)
                {
                    sebzes = 10 + ero;
                    root = 1;
                    pmanaduh = -10;
                    manavaltozas();
                    manaduh.Text = "Mana:" + mana + "/100";
                    GyozelemVereseg();
                    ellenfel();
                }
                else
                {
                    eroot -= 1;
                    ellenfel();
                }
            }
        }
        private void htamadas_Click(object sender, RoutedEventArgs e)
        {
            
            if (klassz == "Harcos" && duh >= 60)
            {
                sebzes = 50 + ero;
                pmanaduh = -60;
                duhvaltozas();
                manaduh.Text = "Düh:" + duh + "/100";
                GyozelemVereseg();
                ellenfel();
            }
            if (klassz == "Mágus" && mana >= 40)
            {
                sebzes = 60 + ero;
                pmanaduh = -40;
                manavaltozas();
                if (eges > 0)
                {
                    sebzes += 5;
                    eges -= 1;
                }
                manaduh.Text = "Mana:" + mana + "/100";
                GyozelemVereseg();
                ellenfel();
            }
            if (klassz == "Druida" && mana >= 30)
            {
                if (eroot == 0)
                {
                    hp += 15;
                    pmanaduh = -20;
                    manavaltozas();
                    hpT.Text = "Hp:" + hp + "/200";
                    manaduh.Text = "Mana:" + mana + "/100";
                    GyozelemVereseg();
                    ellenfel();
                }
                else
                {
                    eroot -= 1;
                    ellenfel();
                }
            }
        }
        /*private void vedekezes_MouseEnter(object sender, MouseEventArgs e)
        {
            A gombok magyarázata akart lenni amikor rajta volt a kurzor, de egyelőre ToolTip-ként van megadva
            Újragondolva valószínűleg nem kell az egér pozíciója, elég lesz 4 előre megadott Label vagy Textblock amik a gombok mellett vannak, de egyelőre nem tettem bele
            /*eger = Window1.PointToScreen(Mouse.GetPosition(Window1));
            magyarazat.Width = eger.X;
            magyarazat.Height = eger.Y;
        }*/
    }
}
