using MagsGame.DataStructures;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagsGame.DataStructures;

namespace MagsGame.Board
{
    public class BoardModel
    {
        public BoardModel()
        {


        }

        /// <summary>
        /// Creates the board
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<SquareViewModel> CreateBoard(int sizeX, int sizeY)
        {
            ObservableCollection<SquareViewModel> board = new ObservableCollection<SquareViewModel>();

            for (int j = 0; j < sizeY; j++)
            {
                for (int i = 0; i < sizeX; i++)
                {
                    SquareViewModel a_square = new SquareViewModel(i, j, SquareViewModel.square_type.Normal);
                    if (a_square.BareTileType == SquareViewModel.bare_tile_type.tile1)
                        a_square.ImageName = "/MagsGame;component/Resources/Earth1.jpg";
                    if (a_square.BareTileType == SquareViewModel.bare_tile_type.tile2)
                        a_square.ImageName = "/MagsGame;component/Resources/Earth2.jpg";
                    if (a_square.BareTileType == SquareViewModel.bare_tile_type.tile3)
                        a_square.ImageName = "/MagsGame;component/Resources/Earth3.jpg";
                    if (a_square.BareTileType == SquareViewModel.bare_tile_type.tile4)
                        a_square.ImageName = "/MagsGame;component/Resources/Earth4.jpg";
                    board.Add(a_square);
                }
            }

            return board;
        }


    }
}
