using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagsGame.DataStructures
{
    public class SquareViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public enum square_type
        {
            Normal, Lava, Water, Earth
        };        

        private square_type squareType;
        public square_type SquareType
        {
            get
            {
                return squareType;
            }
            set
            {
                squareType = value;
                if (value == square_type.Lava)
                {
                    LavaPresent = true;
                }
                else
                {
                    LavaPresent = false;
                }
                RaisePropertyChanged("SquareType");
            }
        }

        private bool lavaPresent;
        public bool LavaPresent
        {
            get
            {
                return lavaPresent;
            }
            set
            {
                lavaPresent = value;
                RaisePropertyChanged("LavaPresent");
            }

        }

        public enum bare_tile_type
        {
            tile1, tile2, tile3, tile4
        };

        private bare_tile_type bareTileType;
        public bare_tile_type BareTileType
        {
            get
            {
                return bareTileType;
            }
            set
            {
                bareTileType = value;
                RaisePropertyChanged("BareTileType");
            }
        }

        
        private string imageName;
        public string ImageName
        {
            get
            {
                return imageName;
            }
            set
            {
                imageName = value;
                RaisePropertyChanged("ImageName");
            }

        }


        private int row;
        public int Row
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
                Coords[0] = value;
                RaisePropertyChanged("Row");
                RaisePropertyChanged("Coords");
            }
        }

        private int column;


        public int Column
        {
            get
            {
                return column;
            }
            set
            {
                column = value;
                Coords[0] = value;
                RaisePropertyChanged("Column");
                RaisePropertyChanged("Coords");
            }
        }

        private int[] coords;
        public int[] Coords
        {
            get
            {
                return coords;
            }
            set
            {
                coords = value;
                RaisePropertyChanged("Coords");
            }
        }

        private bool selected;
        public bool Selected
        {
            get => selected;
            set
            {
                selected = value;
                RaisePropertyChanged("Selected");
            }
        }

        private bool highlighted;
        public bool Highlighted
        {
            get => highlighted;
            set
            {
                highlighted = value;
                RaisePropertyChanged("Highlighted");
            }
        }


        public SquareViewModel()
        {
            Random random = new Random();
            double a_val = random.NextDouble();

            if (a_val >= 0.0 && a_val < 0.25)
                this.BareTileType = bare_tile_type.tile1;
            if (a_val >= 0.25 && a_val < 0.5)
                this.BareTileType = bare_tile_type.tile2;
            if (a_val >= 0.5 && a_val < 0.75)
                this.BareTileType = bare_tile_type.tile3;
            if (a_val >= 0.75)
                this.BareTileType = bare_tile_type.tile4;
            Highlighted = false;
            Selected = false;

            this.Coords = new int[] { 0, 0 };
        }

        public SquareViewModel(int _column, int _row,  square_type _square_type)
        {
            this.Coords = new int[] { _column, _row };
            this.Row = _row;
            this.Column = _column;
            this.SquareType = _square_type;
            Random random = new Random((_row + 1) * (_column + 1) + _row + _column);
            int seed = random.Next();
            random = new Random(seed + _row + _column);
            double a_val = random.NextDouble();
            if (a_val >= 0.0 && a_val < 0.25)
                this.BareTileType = bare_tile_type.tile1;
            if (a_val >= 0.25 && a_val < 0.5)
                this.BareTileType = bare_tile_type.tile2;
            if (a_val >= 0.5 && a_val < 0.75)
                this.BareTileType = bare_tile_type.tile3;
            if (a_val >= 0.75)
                this.BareTileType = bare_tile_type.tile4;
            Highlighted = false;
            Selected = false;
        }
    }
}
