using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3OOP.Overriding
{
    internal class TypeB :TypeA
    {
        public int B { get; set; }
        public TypeB(int _a , int _b ) :base(_a)
        {
            B = _b;
        }
        
        public new  void MyFunc()
        {
            Console.WriteLine("I am Child");
        }
        public override void MyFunc2()
        {
            Console.WriteLine($"TypeB : B {B}");
        }
    }
}
