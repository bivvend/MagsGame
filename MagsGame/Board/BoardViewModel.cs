using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagsGame.DataStructures;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MagsGame.Board
{
    public class BoardViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public BoardModel boardModel { get; set; }
        public SquareViewModel SelectedSquare { get; set; }

        public ICommand SquareClickCommand { get; private set; }

        private int sizeX;
        public int SizeX
        {
            get
            {
                return sizeX;
            }
            set
            {
                sizeX = value;
                RaisePropertyChanged("SizeX");
            }
        }

        private int sizeY;
        public int SizeY
        {
            get
            {
                return sizeY;
            }
            set
            {
                sizeY = value;
                RaisePropertyChanged("SizeY");
            }
        }

        private ObservableCollection<SquareViewModel> board;
        public ObservableCollection<SquareViewModel> Board
        {
            get
            {
                return board;
            }
            set
            {
                board = value;
                RaisePropertyChanged("Board");
            }
        }

        private string pieceInfoString = "No piece selected";
        public string PieceInfoString
        {
            get => pieceInfoString;
            set
            {
                pieceInfoString = value;
                RaisePropertyChanged("PieceInfoString");
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public BoardViewModel(BoardModel boardModelIn)
        {
            boardModel = boardModelIn;
            SquareClickCommand = new RelayCommand(SquareClickExecute, param => true);
        }

        public void SquareClickExecute(object obj)
        {
            int[] Coords = (int[])obj;
            foreach (SquareViewModel square in Board)
            {
                if (square.Row == Coords[1] && square.Column == Coords[0])
                {
                    square.SquareType = SquareViewModel.square_type.Lava;                    

                }
            }
        }

    }
}
