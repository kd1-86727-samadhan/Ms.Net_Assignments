using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Question01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.AcceptDetails();
            st.PrintDetails();    
            //Console.WriteLine(st.DisplayDetails());
        }

        public class Student
        {
            private string _Name;

            private bool _Gender;

            private int _Age;

            private int  _Std;

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

            public void AcceptDetails()
            {
                Console.WriteLine("Enter the name: ");
                _Name= Console.ReadLine();

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
            
            public string DisplayDetails()
            {
                return Name + Gender + Age.ToString() + Std.ToString() + Div + Marks.ToString();
                       
            }

            public void PrintDetails()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Gender: "+ Gender);
                Console.WriteLine("Age: " + Age);
                Console.WriteLine("Std: " + Std);
                Console.WriteLine("Div: " + Div);
                Console.WriteLine("Marks: " + Marks);
            }
        }
    }
}

