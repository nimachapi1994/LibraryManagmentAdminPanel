using MD.PersianDateTime.Core;
using System;

namespace BookShop.GeneralMethods
{
    public class ConvertMidaldiToShamsiDigit : IConvertMiladiToPersian
    {

        public string ConvertMidaldiToShamsi(DateTime? dateTime)
        {
            
            return new PersianDateTime(dateTime).ToShortDateString();
        }

    }
}
