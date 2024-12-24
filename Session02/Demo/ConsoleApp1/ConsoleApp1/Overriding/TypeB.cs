using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Overriding
{
    internal class TypeB:TypeA
    {
        public int B { get; set; }
        public TypeB(int _A,int _B) : base(_A)
        {
            B = _B;
        }
        public new void MyFunction01()
        {
            Console.WriteLine("I'm Chiled");
        }
        public override void MyFunction02()
        {
            Console.WriteLine($"B is {B}, A is {A}");
        }
    }
}
