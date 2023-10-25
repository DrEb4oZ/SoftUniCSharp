using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public static class DateModifier
    {


        public static int GetDifferenceInDays(string fistDate, string secondDate)
        {
            DateTime startDate = DateTime.Parse(fistDate);
            DateTime endDate = DateTime.Parse(secondDate);
            
            TimeSpan difference = startDate - endDate;
            return Math.Abs(difference.Days);
        }
    }
}
