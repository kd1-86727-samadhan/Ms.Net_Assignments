using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Date
    {
        private int _Day;
        private int _Month;
        private int _Year;

        public Date()
        {
            _Day = 0;
            _Month = 0;
            _Year = 0;
        }

        public Date(int day, int month, int year)
        {
            _Day = day;
            _Month = month;
            _Year = year;
        }

        public int Year
        {
            get { return _Year; }
            set { _Year = value; }
        }

        public int Month
        {
            get { return _Month; }
            set { _Month = value; }
        }

        public int Day
        {
            get { return _Day; }
            set { _Day = value; }
        }

        public void AcceptDate()
        {
            Console.WriteLine("Enter the day: ");
            _Day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the month: ");
            _Month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the day: ");
            _Year = Convert.ToInt32(Console.ReadLine());


        }
        public void PrintDate()
        {
            Console.WriteLine("PrintDate()");
            Console.WriteLine(_Day + "/" + _Month + "/" + _Year);
        }
        public string DisplayDate()
        {
            return Day.ToString() + "/" + Month.ToString() + "/" + Year.
                ToString();
        }

        public bool IsValidate()
        {
            if (this._Year >= 1947 && this._Year <= 2024)
            {
                if (this._Month >= 1 && this._Month <= 12)
                {
                    if (this._Day >= 1 && this._Day <= 31)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static int CalculateDifference(Date dt1, Date dt2)
        {
            return (dt1._Year - dt2._Year);
        }

        public static int operator -(Date dt1, Date dt2)
        {
            return CalculateDifference(dt1, dt2);
        }
    }
}
