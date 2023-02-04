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
        public static Color Czytaj()
        {
            Properties.Settings ustawienia = Properties.Settings.Default;
            Color kolor = new Color()
            {
                A = 255,
                R = ustawienia.R,
                G = ustawienia.G,
                B = ustawienia.B
            };
            return kolor;
        }
        public static void Zapisz(Color kolor)
        {
            Properties.Settings ustawienia = Properties.Settings.Default;
            ustawienia.R = kolor.R;
            ustawienia.G = kolor.G;
            ustawienia.B = kolor.B;
            ustawienia.Save();
        }

    }
}
