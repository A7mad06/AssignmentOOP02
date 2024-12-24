using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Overriding
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int _A)
        {
            A = _A;
        }
        public void MyFunction01()
        {
            Console.WriteLine("I'm Base Parent");
        }
        public virtual void MyFunction02()
        {
            Console.WriteLine($"A is {A}");
        }
    }
}
