using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Parent()
        {

        }
        public Parent(int _X,int _Y)
        {
            X = _X;
            Y = _Y;
        }
        public override string ToString()
        {
            return $"X:{X},Y:{Y}";
        }
    }
}
