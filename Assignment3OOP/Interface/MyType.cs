using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3OOP.Interface
{
    internal class MyType : IMyType
    {
        int Salary;
        int IMyType.Age { 
            get => Salary; 
            set { Salary = value; } }

        public void myFunc()
        {
            Console.WriteLine("Hello Route! ");
        }
        public void MyTypeFunc()
        {
            Console.WriteLine("hello");
        }
    }
}
