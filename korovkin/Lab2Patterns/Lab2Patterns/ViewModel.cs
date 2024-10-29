using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
namespace Lab2Patterns
{
    public class ViewModel : INotifyPropertyChanged
    {
        bool[,] field;
        public int width = 10;
        public int height = 10;
        bool gameNotOver = true;
        Random rand = new Random();
        int bombsNum = 15;
        public int Width
        {
            get { return width; }
            set
            {
                width = Math.Clamp(value, 10, 30);
                OnPropertyChanged("Width");
            }
        }
        public bool GameNotOver
        {
            get { return gameNotOver; }
            set
            {
                gameNotOver = value;
                OnPropertyChanged("GameNotOver");
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                height = Math.Clamp(value, 10, 30);
                OnPropertyChanged("Height");
            }
        }
        public ObservableCollection<Cell> Cells { get; set; } =
     new ObservableCollection<Cell>() ;
        public ViewModel()
        {

            
        }
        private RelayCommand generateFieldCommand;
        public RelayCommand GenerateFieldCommand
        {
            get
            {
                return generateFieldCommand ??
                (generateFieldCommand = new RelayCommand(obj =>
                { 
                    Cells.Clear();
                    bombsNum = (Height * Width) / 3;
                    int BombsLeft = bombsNum;
                    GameNotOver = true;
                    if (Height < 0 || Width < 0)
                    {
                        MessageBox.Show("Неверные данные");
                        return;
                    }
                    
                    field = new bool[Height,Width];
                    while(BombsLeft>0)
                    {
                        int i= rand.Next(0, Height - 1);
                        int j = rand.Next(0, Width - 1);
                        if (field[i, j] == false)
                        {
                            field[i, j] = true;
                            BombsLeft--;
                        }
                      
                         //   if (rnd==true&&bombsNum > 0)
                          //  {
                        //        bombsNum--;
                       //         field[i, j] = true;
                       //     }
                         //   else
                       //     {
                        //        field[i, j] = false;
                        //    }
                      
                    }
                  
                    string test="";
                    for (int i=0; i < Height; i++)
                    {
                        
                        for (int j = 0; j < Width; j++)
                        {
                         //   test = j.ToString()+" "+i.ToString();
                            if (field[i, j] == true)
                            {
                             //   test += " b";
                            }
                            Cell newcell = new Cell( ActivateCellCommand,MarkCellCommand,j,i,field[i,j],0,test);
                            Cells.Insert(0, newcell);
                        }
                    }
                  
                }));
            }
        }
        private RelayCommand activateCellCommand;
        public RelayCommand ActivateCellCommand
        {
            get
            {
                return activateCellCommand ??
                (activateCellCommand = new RelayCommand(obj =>
                {
                    Cell cell = obj as Cell;
                    cell.IsActive = false;
                   
                    if (cell.IsBomb)
                    {
                        GameNotOver = false;
                        MessageBox.Show("Game over");
                        return;
                    }
                    int bombs = 0;
                    
                    for (int i = cell.Y-1; i < cell.Y + 2; i++)
                    {
                        for (int j = cell.X - 1; j < cell.X + 2; j++)
                        {
                            if ((i>=0)&&(i<Height)&&(j>=0)&&(j<Width)) 
                                {
                                if(field[i,j]==true)
                                {
                                    bombs += 1;
                                }
                                } 
                        }
                    }
                    cell.BombsAroundNum = bombs;
                    cell.DisplayValue = cell.BombsAroundNum.ToString();

              
                }));
            }
        }
        private RelayCommand markCellCommand;
        public RelayCommand MarkCellCommand
        {
            get
            {
                return markCellCommand ??
                (markCellCommand = new RelayCommand(obj =>
                {
                    Cell cell = obj as Cell;
                    if (cell.Color == Brushes.Red)
                    {
                    cell.Color = Brushes.White;
                    }
                    else
                    {
                        cell.Color = Brushes.Red;
                    }
                   

                }));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
