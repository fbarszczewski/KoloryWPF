using KoloryWPF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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
                OnPropertyChanged("R", "Color");
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




        public void Zapisz()
        {
            Ustawienia.Zapisz(kolor);
        }

        private ICommand resetujCommand;
        public ICommand Resetuj
        {
            get
            {
                if (resetujCommand == null) resetujCommand = new ResetujCommand(this);
                return resetujCommand;
            }

        }

    }
}
