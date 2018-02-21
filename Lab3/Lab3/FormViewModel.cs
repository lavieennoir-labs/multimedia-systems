using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
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

        private float a;
        public float A
        {
            get { return a; }
            set
            {
                a = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("A"));
            }
        }

        private float angle;
        public float Angle
        {
            get { return angle; }
            set
            {
                angle = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Angle"));
            }
        }

        private string intervalError;
        public string IntervalError
        {
            get { return intervalError; }
            set
            {
                intervalError = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("IntervalError"));
            }
        }

        private string coefError;
        public string CoefError
        {
            get { return coefError; }
            set
            {
                coefError = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("CoefError"));
            }
        }

        private string angleError;
        public string AngleError
        {
            get { return angleError; }
            set
            {
                angleError = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("AngleError"));
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
