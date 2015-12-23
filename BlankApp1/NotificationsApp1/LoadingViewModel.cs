using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace NotificationsApp1
{
    class LoadingViewModel : INotifyPropertyChanged
    {
        private bool _showLoadingIndicator = false;

        public bool ShowLoadingIndicator
        {
            get { return this._showLoadingIndicator; }
            set
            {
                if (value != this._showLoadingIndicator)
                {
                    this._showLoadingIndicator = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public LoadingViewModel()
        {
            this.ShowLoadingIndicator = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propName = null)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
