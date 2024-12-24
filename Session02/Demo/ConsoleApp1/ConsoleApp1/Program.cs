using ConsoleApp1.Overriding;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        //static int sum(int x,int y)
        //{
        //    return x + y;
        //}
        //static int sum(int x,int y,int z)
        //{
        //    return x + y + z;
        //}
        static void Main(string[] args)
        {
            #region Indexer
            //PhoneBook note = new PhoneBook(3);
            //note.AddPerson(0, "Ahmad", 857635);
            //note.AddPerson(1, "Ali", 462424);
            //note.AddPerson(0, "Rana", 039372);
            ////note.SetNumber("Rana", 666);
            //note["Rana"] = 666;
            //Console.WriteLine(note.GetNumber("Rana"));
            #endregion
            #region Class
            //Car c1;
            ////c1 = new Car(); Default constructor removed automatically after creating a constructor
            //c1 = new Car(1, "Bmw", 340.5);
            //Console.WriteLine(c1);
            //c1 = new Car(5);
            //Console.WriteLine(c1);

            #endregion
            #region Inheritance
            //Parent p1 = new Parent(1, 2);
            //Console.WriteLine(p1);
            //Chiled c1 = new Chiled(1, 2, 3);
            //Console.WriteLine(c1);
            #endregion
            #region Releations Between Classes
            //1 Inheritance: is [Full Time Employee is an employee]
            //2 Aggrigation: Has
            //2.1 Composition:
            //2.2 Association: 
            #endregion
            #region Polymorphism
            #region Overloading
            //int result = sum(4, 5, 7);
            //Console.WriteLine(result);
            #endregion
            #region Overriding
            //TypeA a = new TypeA(3);
            //a.MyFunction01();
            //a.MyFunction02();
            //TypeB b = new TypeB(4, 5);
            //b.MyFunction01();
            //b.MyFunction02();
            #endregion
            #endregion
        }
    }
}
