using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MagsGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Board.BoardViewModel MainBoardViewModel;
        public Board.BoardModel MainBoardModel;

        private int SizeX = 22;
        public int SizeY = 15;
        public MainWindow()
        {
            InitializeComponent();

            MainBoardModel = new Board.BoardModel();
            MainBoardViewModel = new Board.BoardViewModel(MainBoardModel);
            MainBoardViewModel.SizeX = SizeX;
            MainBoardViewModel.SizeY = SizeY;

            MainBoardView.DataContext = MainBoardViewModel;
            MainBoardViewModel.Board =  MainBoardModel.CreateBoard(SizeX,SizeY);
        }
    }
}
