using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3OOP.Interface
{
    internal interface IMyType
    {
        public int Age { get; set; }

        public void myFunc();
        
        public void Print()
        {
            Console.WriteLine("Defult Implementation Method");
        }

    }
}
