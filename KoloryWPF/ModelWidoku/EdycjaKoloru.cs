using KoloryWPF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace KoloryWPF.ModelWidoku
{
    public class EdycjaKoloru : INotifyPropertyChanged
    {
        private readonly Kolor kolor = Ustawienia.Czytaj();

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(params string[] nazwyWłasności)
        {
            if (PropertyChanged != null)
            {
                foreach (string nazwaWłasności in nazwyWłasności)
                    PropertyChanged(this, new PropertyChangedEventArgs(nazwaWłasności));
            }
        }

        public byte R
        {
            get
            {
                return kolor.R;
            }
            set
            {
                kolor.R = value;
                OnPropertyChanged("R","Color");
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
                OnPropertyChanged("G", "Color");

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
                OnPropertyChanged("B", "Color");

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
