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

        public bool CanExecute(object parameter)
        {
            return (modelWidoku.R != 0) || (modelWidoku.G != 0) || (modelWidoku.B != 0);
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

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }


    }
}
