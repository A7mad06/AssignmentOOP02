using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }

        public Car(int _Id,string _Model,double _Speed)
        {
            Console.WriteLine(1);
            Id = _Id;
            Model = _Model;
            Speed = _Speed;
        }
        public Car(int _Id,string _Model):this(_Id,_Model,150)
        {
            Console.WriteLine(2);
            //Id = _Id;
            //Model = _Model;
            //Speed = 150;
        }
        public Car(int _Id):this(_Id,"Toyota",150)
        {
            Console.WriteLine(3);
            //Id = _Id;
            //Model = "Toyota";
            //Speed = 150;
        }
        public override string ToString()
        {
            return $"Id={Id}\nModel={Model}\nSpeed={Speed}";
        }
    }
}
