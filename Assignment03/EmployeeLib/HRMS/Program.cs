using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;

namespace HRMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date();
            d1.AcceptDate();
            if(d1.IsValidate())
            {
                Console.WriteLine("Date is valid");
                d1.PrintDate();
            }
            else
            {
                Console.WriteLine("Date is invalid");
            }
            //Console.WriteLine(d.DisplayDate());

            Date d2 = new Date(01, 01, 2022);
            int year = Date.CalculateDifference(d1, d2);
            Console.WriteLine("Difference between two year: " + year);
        }
    }
}
