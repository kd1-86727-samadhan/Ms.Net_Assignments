using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsLib;

namespace Question01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maths maths = new Maths();

            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Sub");
                Console.WriteLine("3. Muliply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        {
                            Console.WriteLine("Exit");
                        }
                        break;

                    case 1:
                        {
                            Console.WriteLine("Enter the first number: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            
                            Console.WriteLine("Enter the second number: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            int result = maths.Sum  (num1, num2);
                            Console.WriteLine("Sum: " + result);
                            
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Enter the first number: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter the second number: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            int result = maths.Subtract(num1, num2);
                            Console.WriteLine("Subtraction: " + result);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter the first number: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter the second number: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            int result = maths.Multiply(num1, num2);
                            Console.WriteLine("Multiplication: " + result);
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter the first number: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter the second number: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            int result = maths.Divide(num1, num2);
                            Console.WriteLine("Divide: " + result);
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Invalid Choice !!!!");
                        }
                        break;
                }
            }   // while
        }
    }
}
