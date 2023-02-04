using KoloryWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace KoloryWPF
{
    static class Ustawienia
    {
        public static Kolor Czytaj()
        {
            Properties.Settings ustawienia = Properties.Settings.Default;
            return new Kolor(ustawienia.R, ustawienia.G, ustawienia.B);
        }
        public static void Zapisz(Kolor kolor)
        {
            Properties.Settings ustawienia = Properties.Settings.Default;
            ustawienia.R = kolor.R;
            ustawienia.G = kolor.G;
            ustawienia.B = kolor.B;
            ustawienia.Save();
        }

    }
}
