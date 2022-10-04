using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05___Property
{
    class Date
    {
        public int month;
        public int day;
        public int year;
        public Date(int theMonth, int theDay, int theYear)
        {
            month = CheckMonth(theMonth);
            day = CheckDay(theDay);
            year = theYear;
        }
        public string ToDateString()
        {
            return day + "/" + month + "/" + year;
        }
        private int CheckDay(int day_check)
        {
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (month == -1) return day_check;
            if (day_check > 0 && day_check <= daysPerMonth[month])
                return day_check;
            if ( month == 2 && day_check == 29 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
                return day_check;
            return -1;
        }
        private int CheckMonth(int month_check)
        {
            if (month_check > 0 && month_check <= 12)
                return month_check;
            else
            {
                return -1;
            }
        }
    }
}
