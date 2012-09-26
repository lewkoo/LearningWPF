using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDKSample
{
    class SquareCube : INotifyPropertyChanged
    {
        private int _value, _square, _cube;

        public int Value
        {
            get { return _value; }
            set
            {
                if (value != _value)
                {
                    _value = value;
                    Square = _value * _value;

                    NotifyPropertyChanged("Value");
                }
            }
        }

        public int Square
        {
            get { return _square; }
            private set
            {
                if (value != _square)
                {
                    _square = value;
                    NotifyPropertyChanged("Square");
                }
            }
        }

        public int Cube
        {
            get { return _cube; }
            private set
            {
                if (value != _cube)
                {
                    _cube = value;
                    NotifyPropertyChanged("Cube");
                }
            }
        }

        public SquareCube(int value)
        {
            Value = value;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
