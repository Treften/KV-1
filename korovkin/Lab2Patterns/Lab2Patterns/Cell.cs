using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
namespace Lab2Patterns
{
    public class Cell : INotifyPropertyChanged
    {
        bool isActive=true;
        bool isBomb;
        string displayValue;
        int bombsAroundNum;
        int x, y;
        SolidColorBrush color;
        public event PropertyChangedEventHandler PropertyChanged;
        public string Content { get; }

        public ICommand CommandLeft { get; }

        public ICommand CommandRight { get; }
        public bool IsBomb
        {
            get { return isBomb; }
            set
            {
                isBomb = value;
                OnPropertyChanged("IsBomb");
            }
        }
        public SolidColorBrush Color
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged("Color");
            }
        }
        public string DisplayValue
        {
            get { return displayValue; }
            set
            {
                displayValue = value;
                OnPropertyChanged("DisplayValue");
            }
        }
        public int BombsAroundNum
        {
            get { return bombsAroundNum; }
            set
            {
                bombsAroundNum = value;
                OnPropertyChanged("BombsAroundNum");
            }
        }
        public bool IsActive
        {
            get { return isActive; }
            set
            {
                isActive = value;
                OnPropertyChanged("IsActive");
            }
        }
        public int X
        {
            get { return x; }
            set
            {
                x = value;
                OnPropertyChanged("X");
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                y = value;
                OnPropertyChanged("Y");
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
        public Cell(ICommand commandLeft, ICommand commandRight ,int x,int y,  bool isBomb, int bombsAroundNum ,string displayValue)

        {

            CommandLeft = commandLeft;
            CommandRight = commandRight;
            IsBomb = isBomb;
            DisplayValue = displayValue;
            BombsAroundNum = bombsAroundNum;
            X = x;
            Y = y;
            Color = Brushes.White;
        }
    }
}
