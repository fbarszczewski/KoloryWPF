using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KoloryWPF.ModelWidoku
{
    public class ResetujCommand : ICommand
    {
        private readonly EdycjaKoloru modelWidoku;
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
                modelWidoku.R = 0;
                modelWidoku.G = 0;
                modelWidoku.B = 0;
        }
        public ResetujCommand(EdycjaKoloru modelWidoku)
        {
            if (modelWidoku == null) throw new ArgumentNullException("modelWidoku");
            this.modelWidoku = modelWidoku;
        }
    }
}
