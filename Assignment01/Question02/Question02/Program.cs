using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    internal class Program
    {
        public static int AcceptNumber()
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            return num;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("------------Menu------------");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Divison");
                Console.WriteLine("----------------------------");

                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        {
                            Console.WriteLine("Exit");
                            return;
                        }

                    case 1:
                        {
                            Console.WriteLine("Addition");
                            int num1 = AcceptNumber();
                            int num2 = AcceptNumber();
                            int res = num1 + num2;
                            Console.WriteLine("Addition: " + res);
                        }
                        break;


                    case 2:
                        {
                            Console.WriteLine("Subtraction");
                            int num1 = AcceptNumber();
                            int num2 = AcceptNumber();
                            int res = num1 - num2;
                            Console.WriteLine("Subtratcion: " + res);
                        }
                        break;


                    case 3:
                        {
                            Console.WriteLine("Multiplication");
                            int num1 = AcceptNumber();
                            int num2 = AcceptNumber();
                            int res = num1 * num2;
                            Console.WriteLine("Multiplication: " + res);
                        }
                        break;

                    case 4:
                        {
                            Console.WriteLine("Division");
                            int num1 = AcceptNumber();
                            int num2 = AcceptNumber();
                            int res = num1 / num2;
                            Console.WriteLine("Divison: " + res);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice !!!!");
                        break;
                }
            }
        }
    }
}
