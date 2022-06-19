using MD.PersianDateTime.Core;
using System;

namespace BookShop.GeneralMethods
{
    public class ConvertMidaldiToShamsiString : IConvertMiladiToPersian
    {


      
        public string ConvertMidaldiToShamsi(DateTime? dateTime)
        {
            return new PersianDateTime(dateTime).ToString("dddd d MMMM yyyy ساعت HH:mm");
        }


    }
}
