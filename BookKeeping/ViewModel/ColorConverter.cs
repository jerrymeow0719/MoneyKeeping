using System;
using System.Globalization;
using Xamarin.Forms;

namespace BookKeeping.ViewModel
{
    public class ColorConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color _color = Color.White;
            switch (value)
            {
                case 1:
                case 2:
                case 3:
                    _color = Color.LightGreen;
                    break;
                case 4:
                case 5:
                case 6:
                    _color = Color.LightPink;
                    break;
                case 7:
                case 8:
                case 9:
                    _color = Color.LightSkyBlue;
                    break;
                case 10:
                case 11:
                case 12:
                    _color = Color.LightGray;
                    break;
            }
            return _color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
