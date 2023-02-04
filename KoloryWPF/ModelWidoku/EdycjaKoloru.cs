using KoloryWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace KoloryWPF.ModelWidoku
{
    internal class EdycjaKoloru
    {
        private readonly Kolor kolor = Ustawienia.Czytaj();

        public byte R
        {
            get
            {
                return kolor.R;
            }
            set
            {
                kolor.R = value;
            }
        }
        public byte G
        {
            get
            {
                return kolor.G;
            }
            set
            {
                kolor.G = value;
            }
        }
        public byte B
        {
            get
            {
                return kolor.B;
            }
            set
            {
                kolor.B = value;
            }
        }

        public Color Color
        {
            get
            {
                return kolor.ToColor();
            }
        }
        public void Zapisz()
        {
            Ustawienia.Zapisz(kolor);
        }

    }
    static class Rozszerzenia
    {
        public static Color ToColor(this Kolor kolor)
        {
            return new Color()
            {
                A = 255,
                R = kolor.R,
                G = kolor.G,
                B = kolor.B
            };
        }
    }
}
