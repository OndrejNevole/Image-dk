using GalaSoft.MvvmLight.Command;
using Imagesdk.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Imagesdk.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private int[,] pixels;

        public RelayCommand AddImage { get; set; }

        public RelayCommand ShadesOfGrey { get; set; }

        public RelayCommand Negative { get; set; }

        public RelayCommand Mirror { get; set; }

        public RelayCommand Reverse { get; set; }

        public BitmapImage BMI { get; set; }

        public MainViewModel()
        {
            AddImage = new RelayCommand(() =>
            {
                var x = 0;
            }
            );

            ShadesOfGrey = new RelayCommand((SolidColorBrush solidColorBrush) =>
            {
                pixels = BitmapImageToArray2D(BitmapImage src);

                for (int x = 0; x < pixels.GetLength(0); x++)
                {
                    for (int y = 0; y < pixels.GetLength(1); y++)
                    {
                        int a = (int)(pixels[x, y] & 0xFF000000);
                        int r = (pixels[x, y] >> 16) & 0xFF;
                        int g = (pixels[x, y] >> 8) & 0xFF;
                        int b = pixels[x, y] & 0xFF;


                        int average = (r + b + g) / 3;
                        pixels[x, y] = a + (average << 16) + (average << 8) + average; 
                    }
                }
                src = ConvertWriteableBitmapToBitmapImage();
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
