using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media;

namespace TestMVVMProject.Converters
{
    public class colorConverter : IValueConverter
    {
        public Brush UnClickedBrush { get; set; } = Brushes.Blue;
        public Brush ClickedBrush { get; set; } = Brushes.LightGreen;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //kontrollera att värdet vi får in är en bool.
            // Om värder är en bool --> tilldela det värdet till variablen b
            // Kontrollera sedan om b är true
            if (value is bool b && b)
            {
                return ClickedBrush;
            }
            return UnClickedBrush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
