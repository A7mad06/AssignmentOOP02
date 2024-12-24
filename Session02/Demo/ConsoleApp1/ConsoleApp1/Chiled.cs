using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Chiled:Parent
    {
        public int Z { get; set; }
        public Chiled(int _X,int _Y,int _Z) : base(_X,_Y)
        {
            Z = _Z;
        }
        public override string ToString()
        {
            return $"X:{X},Y:{Y},Z:{Z}";
        }
    }
}
