using MD.PersianDateTime.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.GeneralMethods
{
    public class PersianDatetimeCalculator
    {
        public static DateTime ConvertShamsiToMiladi(string date)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            string[] parts = date.Split('/');
            int[] getPartIndex = new int[parts.Length];

            parts.ToList().ForEach(x => getPartIndex.ToList().Add(Convert.ToInt32(x)));
            return persianCalendar.
                ToDateTime(getPartIndex[0], getPartIndex[1], getPartIndex[2], 0, 0, 0, 0);
        }
        public static string ConvertMidaldiToShamsi(DateTime? dateTime)
        {
            return new PersianDateTime(dateTime).ToString("dddd d MMMM yyyy ساعت HH:mm");
        }

    }
}
