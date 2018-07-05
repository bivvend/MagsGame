using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagsGame.PieceDisplay
{
    public class PieceDisplayViewModel: INotifyPropertyChanged 
    {
        public PieceDisplayModel model;

        public PieceDisplayViewModel(PieceDisplayModel modelIn)
        {
            model = modelIn;

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
