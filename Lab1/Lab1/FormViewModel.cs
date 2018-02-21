using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class FormViewModel : INotifyPropertyChanged
    {
        private int minX;
        public int MinX
        {
            get { return minX; }
            set
            {
                minX = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("MinX"));
            }
        }

        private int maxX;
        public int MaxX
        {
            get { return maxX; }
            set
            {
                maxX = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("MaxX"));

            }
        }

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, e);
        }

        #endregion
    }
}
