using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Imagesdk.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public RelayCommand AddImage { get; set; }

        public RelayCommand ShadesOfGrey { get; set; }

        public RelayCommand Negative { get; set; }

        public RelayCommand Mirror { get; set; }

        public RelayCommand Reverse { get; set; }
        public MainViewModel()
        {
            AddImage = new RelayCommand(() =>
            {
                var x = 0;
            }
            );

            ShadesOfGrey = new RelayCommand(() =>
            {
                var x = 0;
            }
            );

            Negative = new RelayCommand(() =>
            {
                var x = 0;
            }
            );

            Mirror = new RelayCommand(() =>
            {
                var x = 0;
            }
            );

            Reverse = new RelayCommand(() =>
            {
                var x = 0;
            }
);

        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
