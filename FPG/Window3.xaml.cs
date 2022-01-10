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
        //az alap adatok
        //fájlból kiolvasott
        string nev, ellnev;
        int ero, ved, moz, intl, xp, eero, eved, emoz, eintl, exp;
        //számolásokhoz használt
        int hp = 200, ellhp = 200;
        int duh, mana, eduh, emana;
        bool harcvege = false;
        int eges, eeges;
        int root, eroot;
        int ihp, eihp, ixp, iexp, imana, iemana, iduh, ieduh;
        int veletlen;
        int i = 0;
        int sebzes = 0;
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
            vedekezes.Width = 0;
            vedekezes.Height = 0;
            tamadas.Width = 0;
            tamadas.Height = 0;
            mtamadas.Width = 0;
            mtamadas.Height = 0;
            htamadas.Width = 0;
            htamadas.Height = 0;
            hpT.Width = 0;
            hpT.Height = 0;
            ellhpT.Width = 0;
            ellhpT.Height = 0;
            manaduh.Width = 0;
            manaduh.Height = 0;
            emanaduh.Width = 0;
            emanaduh.Height = 0;
        }
        public void GyozelemVereseg()
        {
            if (ellhp <= 0)
            {
                
                Gombtuntetes();
                emhp.Width = 0;
                emhp.Height = 0;
                mhp.Width = 0;
                mhp.Height = 0;
                mmanaduh.Width = 0;
                mmanaduh.Height = 0;
                emmanaduh.Width = 0;
                emmanaduh.Height = 0;
                parbeszedT.Text = "\t \t Győzelem! :)";
                tovabb.IsEnabled = true;
                tovabb.Width = 200;
                tovabb.Height = 60;
                harcvege = true;
                ellhpT.Text = "Hp:0/200";
                ixp = xp;
                iexp = exp;
                xp += 1000;
                exp += 500;
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
            else if (hp <= 0)
            {
                
                Gombtuntetes();
                emhp.Width = 0;
                emhp.Height = 0;
                mhp.Width = 0;
                mhp.Height = 0;
                mmanaduh.Width = 0;
                mmanaduh.Height = 0;
                emmanaduh.Width = 0;
                emmanaduh.Height = 0;
                parbeszedT.Text = "\t \t Vereség! :(";
                tovabb.IsEnabled = true;
                tovabb.Width = 200;
                tovabb.Height = 60;
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
            Random r = new Random();
            dodger = r.Next(0, 201);
            dodge = moz * 10;
            if (dodge > dodger)
            {
                dodged = true;
                mhp.Text = $"dodged";
            }
            else
            {
                dodged = false;
            }
            return dodged;
        }
        public bool emozgszam()
        {
            Random r = new Random();
            edodger = r.Next(0, 201);
            edodge = emoz * 10;
            if (edodge > edodger)
            {
                edodged = true;
                emhp.Text = $"dodged";
            }
            else
            {
                edodged = false;
            }
            return edodged;
        }
        public void kepek()
        {
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
        public void ellenfel()
        {
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
            switch (szandek)
            {
                case 1: //vedekezes
                    switch (eklassz)
                    {
                        case "Harcos":
                            intention.Text = "Védekezés";
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
                                    emhp.Text = $"+{Math.Abs(eihp- ellhp)}hp";
                                }
                            }
                            ellhpT.Text = "Hp:" + ellhp + "/200";
                            ieduh = eduh;
                            eduh += 5 + eintl;
                            manaduhteszt();
                            if (ieduh - eduh > 0)
                            {
                                emmanaduh.Text = $"-{ieduh - eduh}düh";
                            }
                            else
                            {
                                emmanaduh.Text = $"+{Math.Abs(ieduh - eduh)}düh";
                            }
                            emanaduh.Text = "Düh:" + eduh + "/100";
                            GyozelemVereseg();
                            break;
                        case "Mágus":
                            intention.Text = "Buborék";
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
                                    emhp.Text = $"+{Math.Abs(eihp- ellhp)}hp";
                                }
                            }
                            ellhpT.Text = "Hp:" + ellhp + "/200";
                            iemana = emana;
                            emana += 5 + eintl;
                            manaduhteszt();
                            emmanaduh.Text = $"{emana - iemana}mana";
                            emanaduh.Text = "Mana:" + emana + "/100";
                            GyozelemVereseg();
                            break;
                        case "Íjász":
                            break;
                        case "Druida":
                            if (root == 0)
                            {
                                intention.Text = "Teknőspáncél";
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
                                        emhp.Text = $"+{Math.Abs(eihp- ellhp)}hp";
                                    }
                                }
                                iemana = emana;
                                emana += 10 + eintl;
                                manaduhteszt();
                                if (iemana - emana > 0)
                                {
                                    emmanaduh.Text = $"-{iemana - emana}mana";
                                }
                                else
                                {
                                    emmanaduh.Text = $"+{Math.Abs(iemana - emana)}mana";
                                }
                                ellhpT.Text = "Hp:" + ellhp + "/200";
                                hpT.Text = "Hp:" + hp + "/200";
                                emanaduh.Text = "Mana:" + emana + "/100";
                                GyozelemVereseg();
                            }
                            else
                            {
                                root -= 1;
                                intention.Text = "Teknőspáncél";
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
                                        emhp.Text = $"+{Math.Abs(eihp- ellhp)}hp";
                                    }
                                }
                                iemana = emana;
                                emana += 10 + eintl;
                                manaduhteszt();
                                if (iemana - emana > 0)
                                {
                                    emmanaduh.Text = $"-{iemana - emana}mana";
                                }
                                else
                                {
                                    emmanaduh.Text = $"+{Math.Abs(iemana - emana)}mana";
                                }
                                ellhpT.Text = "Hp:" + ellhp + "/200";
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
                                    emhp.Text = $"+{Math.Abs(eihp- ellhp)}hp";
                                }
                            }
                            mozgszam();
                            if (dodged == false)
                            {
                                ihp = hp;
                                hp -= 10 + eero - ved;
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
                                    mhp.Text = $"+{Math.Abs(ihp- hp)}hp";
                                }
                            }
                            ellhpT.Text = "Hp:" + ellhp + "/200";
                            hpT.Text = "Hp:" + hp + "/200";
                            ieduh = eduh;
                            eduh += 20 + eintl;
                            manaduhteszt();
                            if (ieduh - eduh > 0)
                            {
                                emmanaduh.Text = $"-{ieduh - eduh}düh";
                            }
                            else
                            {
                                emmanaduh.Text = $"+{Math.Abs(ieduh - eduh)}düh";
                            }
                            emanaduh.Text = "Düh:" + eduh + "/100";
                            GyozelemVereseg();
                            break;
                        case "Mágus":
                            if (emana >= 15)
                            {
                                intention.Text = "Tűzgolyó";
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
                                        emhp.Text = $"+{Math.Abs(eihp- ellhp)}hp";
                                    }
                                }
                                mozgszam();
                                if (dodged == false)
                                {
                                    ihp = hp;
                                    hp -= 10 + eero - ved;
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
                                        mhp.Text = $"+{Math.Abs(ihp- hp)}hp";
                                    }
                                }
                                eeges += 2;
                                if (eeges > 0)
                                {
                                    ihp = hp;
                                    hp -= 10 - ved;
                                    if (hp > ihp)
                                    {
                                        hp = ihp;
                                    }
                                }
                                iemana = emana;
                                emana -= 5 - eintl;
                                manaduhteszt();
                                if (iemana - emana > 0)
                                {
                                    emmanaduh.Text = $"-{iemana - emana}mana";
                                }
                                else
                                {
                                    emmanaduh.Text = $"+{Math.Abs(iemana - emana)}mana";
                                }
                                ellhpT.Text = "Hp:" + ellhp + "/200";
                                hpT.Text = "Hp:" + hp + "/200";
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
                                        emhp.Text = $"+{Math.Abs(eihp- ellhp)}hp";
                                    }
                                }
                                mozgszam();
                                if (dodged == false)
                                {
                                    ihp = hp;
                                    hp -= 10 + eero - ved;
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
                                        mhp.Text = $"+{Math.Abs(ihp- hp)}hp";
                                    }
                                }
                                iemana = emana;
                                emana += 10 + eintl;
                                manaduhteszt();
                                if (iemana - emana > 0)
                                {
                                    emmanaduh.Text = $"-{iemana - emana}mana";
                                }
                                else
                                {
                                    emmanaduh.Text = $"+{Math.Abs(iemana - emana)}mana";
                                }
                                ellhpT.Text = "Hp:" + ellhp + "/200";
                                hpT.Text = "Hp:" + hp + "/200";
                                emanaduh.Text = "Mana:" + emana + "/100";
                                GyozelemVereseg();
                            }
                            else
                            {
                                root -= 1;
                                intention.Text = "Karmolás";
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
                                        emhp.Text = $"+{Math.Abs(eihp- ellhp)}hp";
                                    }
                                }
                                iemana = emana;
                                emana += 10 + eintl;
                                manaduhteszt();
                                if (iemana - emana > 0)
                                {
                                    emmanaduh.Text = $"-{iemana - emana}mana";
                                }
                                else
                                {
                                    emmanaduh.Text = $"+{Math.Abs(iemana - emana)}mana";
                                }
                                ellhpT.Text = "Hp:" + ellhp + "/200";
                                hpT.Text = "Hp:" + hp + "/200";
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
                                mozgszam();
                                if (dodged == false)
                                {
                                    ihp = hp;
                                    hp -= 20 + eero - ved;
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
                                ellhpT.Text = "Hp:" + ellhp + "/200";
                                hpT.Text = "Hp:" + hp + "/200";
                                ieduh = eduh;
                                eduh -= 30 - eintl;
                                manaduhteszt();
                                if (ieduh - eduh > 0)
                                {
                                    emmanaduh.Text = $"-{ieduh - eduh}düh";
                                }
                                else
                                {
                                    emmanaduh.Text = $"+{Math.Abs(ieduh - eduh)}düh";
                                }
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
                                mozgszam();
                                if (dodged == false)
                                {
                                    ihp = hp;
                                    hp -= 10 + eero - ved;
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
                                eeges += 2;
                                if (eeges > 0)
                                {
                                    eeges = 0;
                                    ihp = hp;
                                    hp -= 5 - ved;
                                    if (hp > ihp)
                                    {
                                        hp = ihp;
                                    }
                                }
                                iemana = emana;
                                emana -= 5 - eintl;
                                manaduhteszt();
                                if (iemana - emana > 0)
                                {
                                    emmanaduh.Text = $"-{iemana - emana}mana";
                                }
                                else
                                {
                                    emmanaduh.Text = $"+{Math.Abs(iemana - emana)}mana";
                                }
                                ellhpT.Text = "Hp:" + ellhp + "/200";
                                hpT.Text = "Hp:" + hp + "/200";
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
                                    mozgszam();
                                    if (dodged == false)
                                    {
                                        ihp = hp;
                                        hp -= 10 + eero - ved;
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
                                    eroot += 1;
                                    iemana = emana;
                                    emana -= 10 - eintl;
                                    manaduhteszt();
                                    if (iemana - emana > 0)
                                    {
                                        emmanaduh.Text = $"-{iemana - emana}mana";
                                    }
                                    else
                                    {
                                        emmanaduh.Text = $"+{Math.Abs(iemana - emana)}mana";
                                    }
                                    ellhpT.Text = "Hp:" + ellhp + "/200";
                                    hpT.Text = "Hp:" + hp + "/200";
                                    emanaduh.Text = "Mana:" + emana + "/100";
                                    GyozelemVereseg();
                                }
                                else
                                {
                                    root -= 1;
                                    intention.Text = "Gyökércsapda";
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
                                    iemana = emana;
                                    emana += 10 + eintl;
                                    manaduhteszt();
                                    if (iemana - emana > 0)
                                    {
                                        emmanaduh.Text = $"-{iemana - emana}mana";
                                    }
                                    else
                                    {
                                        emmanaduh.Text = $"+{Math.Abs(iemana - emana)}mana";
                                    }
                                    ellhpT.Text = "Hp:" + ellhp + "/200";
                                    hpT.Text = "Hp:" + hp + "/200";
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
                                mozgszam();
                                if (edodged == false)
                                {
                                    ihp = hp;
                                    hp -= 40 + eero - ved;
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
                                ellhpT.Text = "Hp:" + ellhp + "/200";
                                hpT.Text = "Hp:" + hp + "/200";
                                ieduh = eduh;
                                eduh -= 60 - eintl;
                                manaduhteszt();
                                if (ieduh - eduh > 0)
                                {
                                    emmanaduh.Text = $"-{ieduh - eduh}düh";
                                }
                                else
                                {
                                    emmanaduh.Text = $"+{Math.Abs(ieduh - eduh)}düh";
                                }
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
                                mozgszam();
                                if (dodged == false)
                                {
                                    ihp = hp;
                                    hp -= 60 - ved;
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
                                    eeges -= 1;
                                    ihp = hp;
                                    hp -= 5 - ved;
                                    if (hp > ihp)
                                    {
                                        hp = ihp;
                                    }
                                }
                                iemana = emana;
                                emana -= 30 - eintl;
                                manaduhteszt();
                                if (iemana - emana > 0)
                                {
                                    emmanaduh.Text = $"-{iemana - emana}mana";
                                }
                                else
                                {
                                    emmanaduh.Text = $"+{Math.Abs(iemana - emana)}mana";
                                }
                                hpT.Text = "Hp:" + hp + "/200";
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
                                    eroot += 1;
                                    iemana = emana;
                                    emana -= 20 - eintl;
                                    manaduhteszt();
                                    if (iemana - emana > 0)
                                    {
                                        emmanaduh.Text = $"-{iemana - emana}mana";
                                    }
                                    else
                                    {
                                        emmanaduh.Text = $"+{Math.Abs(iemana - emana)}mana";
                                    }
                                    ellhpT.Text = "Hp:" + ellhp + "/200";
                                    hpT.Text = "Hp:" + hp + "/200";
                                    emanaduh.Text = "Mana:" + emana + "/100";
                                    GyozelemVereseg();
                                }
                                else
                                {
                                    root -= 1;
                                    intention.Text = "Élet növénye";
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
                                    iemana = emana;
                                    emana += 10 + eintl;
                                    manaduhteszt();
                                    if (iemana - emana > 0)
                                    {
                                        emmanaduh.Text = $"-{iemana - emana}mana";
                                    }
                                    else
                                    {
                                        emmanaduh.Text = $"+{Math.Abs(iemana - emana)}mana";
                                    }
                                    ellhpT.Text = "Hp:" + ellhp + "/200";
                                    hpT.Text = "Hp:" + hp + "/200";
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
            playernev.Width = 0;
            playernev.Height = 0;
            ellenfelnev.Width = 0;
            ellenfelnev.Height = 0;
            playernev1.Width = 0;
            playernev1.Height = 0;
            ellenfelnev1.Width = 0;
            ellenfelnev1.Height = 0;
            parbeszedT.Height = 180;
            parbeszedT.Width = 1252;
        }
        public void statolvasas()
        {
            try
            {
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
            catch (System.StackOverflowException)
            {

                MessageBox.Show("wtf");
            }
        }
        public void harckezdet()
        {
            //Tovább gombot "eltüntetjük", a többit megidézzük
            tovabb.IsEnabled = false;
            tovabb.Width = 0;
            tovabb.Height = 0;
            vedekezes.Width = 340;
            vedekezes.Height = 60;
            tamadas.Width = 340;
            tamadas.Height = 60;
            mtamadas.Width = 340;
            mtamadas.Height = 60;
            htamadas.Width = 340;
            htamadas.Height = 60;
            hpT.Width = 227;
            hpT.Height = 48;
            ellhpT.Width = 227;
            ellhpT.Height = 48;
            manaduh.Width = 227;
            manaduh.Height = 48;
            emanaduh.Width = 227;
            emanaduh.Height = 48;
            hpT.Text = "Hp: 200/200";
            ellhpT.Text = "Hp: 200/200";
            //Minden karakternek saját gombneveket állítunk
            statolvasas();
            switch (klassz)
            {
                case "Harcos":
                    manaduh.Text = "Düh:0/100";
                    break;
                case "Mágus":
                    manaduh.Text = "Mana:0/100";
                    vedekezes.Content = "Buborék";
                    tamadas.Content = "Tűzgolyó";
                    mtamadas.Content = "Jégcsap";
                    htamadas.Content = "Robbanás";
                    break;
                case "Íjász":
                    break;
                case "Druida":
                    manaduh.Text = "Mana:0/100";
                    vedekezes.Content = "Teknőspáncél";
                    tamadas.Content = "Karmolás";
                    mtamadas.Content = "Gyökércsapda";
                    htamadas.Content = "Élet növénye";
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
            parbeszedT.Height = 0;
            parbeszedT.Width = 0;
        }
        private void playernev1_TextChanged(object sender, TextChangedEventArgs e)
        {
            nev = playernev1.Text;
            pnev.Text = playernev1.Text;
        }
        private void ellenfelnev1_TextChanged(object sender, TextChangedEventArgs e)
        {
            ellnev = ellenfelnev1.Text;
            enev.Text = ellenfelnev1.Text;
        }
        private void tovabb_Click(object sender, RoutedEventArgs e)
        {
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
                    if (harcvege == true)
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
                catch (FileNotFoundException)
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
                    iduh = duh;
                    duh += 5 + intl;
                    manaduhteszt();
                    if (iduh - duh > 0)
                    {
                        mmanaduh.Text = $"-{iduh - duh}düh";
                    }
                    else
                    {
                        mmanaduh.Text = $"+{Math.Abs(iduh - duh)}düh";
                    }
                    manaduh.Text = "Düh:" + duh + "/100";
                    sebzes = 0;
                    GyozelemVereseg();
                    ellenfel();
                    break;
                case "Mágus":
                    imana = mana;
                    mana += 5 + intl;
                    manaduhteszt();
                    if (imana - mana > 0)
                    {
                        mmanaduh.Text = $"-{imana - mana}mana";
                    }
                    else
                    {
                        mmanaduh.Text = $"+{Math.Abs(imana - mana)}mana";
                    }
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
                        imana = mana;
                        mana += 5 + intl;
                        manaduhteszt();
                        if (imana - mana > 0)
                        {
                            mmanaduh.Text = $"-{imana - mana}mana";
                        }
                        else
                        {
                            mmanaduh.Text = $"+{Math.Abs(imana - mana)}mana";
                        }
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
                iduh = duh;
                duh += 20 + intl;
                manaduhteszt();
                if (iduh - duh > 0)
                {
                    mmanaduh.Text = $"-{iduh - duh}düh";
                }
                else
                {
                    mmanaduh.Text = $"+{Math.Abs(iduh - duh)}düh";
                }
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
                imana = mana;
                mana -= 5 - intl;
                manaduhteszt();
                if (imana - mana > 0)
                {
                    mmanaduh.Text = $"-{imana - mana}mana";
                }
                else
                {
                    mmanaduh.Text = $"+{Math.Abs(imana - mana)}mana";
                }
                manaduh.Text = "Mana:" + mana + "/100";
                GyozelemVereseg();
                ellenfel();
            }
            if (klassz == "Druida")
            {
                if (eroot == 0)
                {
                    sebzes = 10 + ero;
                    imana = mana;
                    mana += 10 + intl;
                    manaduhteszt();
                    if (imana - mana > 0)
                    {
                        mmanaduh.Text = $"-{imana - mana}mana";
                    }
                    else
                    {
                        mmanaduh.Text = $"+{Math.Abs(imana - mana)}mana";
                    }
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
                iduh = duh;
                duh -= 30 - intl;
                manaduhteszt();
                if (iduh - duh > 0)
                {
                    mmanaduh.Text = $"-{iduh - duh}düh";
                }
                else
                {
                    mmanaduh.Text = $"+{Math.Abs(iduh - duh)}düh";
                }
                manaduh.Text = "Düh:" + duh + "/100";
                GyozelemVereseg();
                ellenfel();
            }
            if (klassz == "Mágus" && mana >= 15)
            {
                sebzes = 10 + ero;
                imana = mana;
                mana -= 5 - intl;
                manaduhteszt();
                if (imana - mana > 0)
                {
                    mmanaduh.Text = $"-{imana - mana}mana";
                }
                else
                {
                    mmanaduh.Text = $"+{Math.Abs(imana - mana)}mana";
                }
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
                    imana = mana;
                    mana -= 10 - intl;
                    manaduhteszt();
                    if (imana - mana > 0)
                    {
                        mmanaduh.Text = $"-{imana - mana}mana";
                    }
                    else
                    {
                        mmanaduh.Text = $"+{Math.Abs(imana - mana)}mana";
                    }
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
                iduh = duh;
                duh -= 60 - intl;
                manaduhteszt();
                if (iduh - duh > 0)
                {
                    mmanaduh.Text = $"-{iduh - duh}düh";
                }
                else
                {
                    mmanaduh.Text = $"+{Math.Abs(iduh - duh)}düh";
                }
                manaduh.Text = "Düh:" + duh + "/100";
                GyozelemVereseg();
                ellenfel();
            }
            if (klassz == "Mágus" && mana >= 40)
            {
                sebzes = 60 + ero;
                imana = mana;
                mana -= 40 - intl;
                manaduhteszt();
                if (imana - mana > 0)
                {
                    mmanaduh.Text = $"-{imana - mana}mana";
                }
                else
                {
                    mmanaduh.Text = $"+{Math.Abs(imana - mana)}mana";
                }
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
                    imana = mana;
                    mana -= 20 - intl;
                    manaduhteszt();
                    if (imana - mana > 0)
                    {
                        mmanaduh.Text = $"-{imana - mana}mana";
                    }
                    else
                    {
                        mmanaduh.Text = $"+{Math.Abs(imana - mana)}mana";
                    }
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
    }
}
