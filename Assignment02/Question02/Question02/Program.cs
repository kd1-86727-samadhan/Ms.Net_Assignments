using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    public class Program
    {
        public static void CreateArray(out Student[] st)
        {
            Console.WriteLine("Enter the size if an array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            st = new Student[size];

            for (int i = 0; i < size; i++)
            {
                st[i] = new Student();
            }
        }

        public static void AcceptInfo(Student[] sarr)
        {
            Console.WriteLine("Enter the Student Details: ");
            for (int i = 0; i < sarr.Length; i++)
            {
                Console.WriteLine("Enter the details - "+ (i+1));
                sarr[i].AcceptInfo();
            }

        }

        public static void PrintInfo(Student[] sarr)
        {
            Console.WriteLine("Student Details: ");
            for (int i = 0; i < sarr.Length; i++)
            {
                sarr[i].PrintInfo();
            }
        }

        public static void ReverseArray(Student[] sarr, out Student[] revArray)
        {
            int size = sarr.Length;
            revArray = new Student[size];

            for (int i = 0; i < size; i++)
            {
                revArray[i] = sarr[size - 1 - i];
            }
        }

        static void Main(string[] args)
        {
            Student[] sarr;

            CreateArray(out sarr);

            AcceptInfo(sarr);

            PrintInfo(sarr);

            Student[] reverseArray;

            ReverseArray(sarr, out reverseArray);

            Console.WriteLine("\nReverseArray Array");

            PrintInfo(reverseArray);
            
        }   // Main function ends here

        public class Student
        {
            private string _Name;

            private bool _Gender;

            private int _Age;

            private int _Std;

            private char _Div;

            private double _Marks;

            public Student()
            {
                Name = "";
                Gender = false;
                Age = 0;
                Std = 0;
                Div = ' ';
                Marks = 0;
            }

            public Student(double marks, char div, int std, int age, bool gender, string name)
            {
                Marks = marks;
                Div = div;
                Std = std;
                Age = age;
                Gender = gender;
                Name = name;
            }

            public double Marks
            {
                get { return _Marks; }
                set { _Marks = value; }
            }

            public char Div
            {
                get { return _Div; }
                set { _Div = value; }
            }

            public int Std
            {
                get { return _Std; }
                set { _Std = value; }
            }

            public int Age
            {
                get { return _Age; }
                set { _Age = value; }
            }

            public bool Gender
            {
                get { return _Gender; }
                set { _Gender = value; }
            }

            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }

            public void AcceptInfo()
            {
                Console.WriteLine("Enter the name: ");
                _Name = Console.ReadLine();

                Console.WriteLine("Enter the gender: ");
                _Gender = bool.Parse(Console.ReadLine());

                Console.WriteLine("Enter the age: ");
                _Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the standard: ");
                _Std = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the div: ");
                _Div = Convert.ToChar(Console.ReadLine());


                Console.WriteLine("Enter the marks: ");
                _Marks = Convert.ToDouble(Console.ReadLine());
            }


            public void PrintInfo()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Gender: " + Gender);
                Console.WriteLine("Age: " + Age);
                Console.WriteLine("Std: " + Std);
                Console.WriteLine("Div: " + Div);
                Console.WriteLine("Marks: " + Marks);
            }
        }
    }
}
