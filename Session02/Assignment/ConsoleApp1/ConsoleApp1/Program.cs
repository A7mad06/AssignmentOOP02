using ConsoleApp1.Company;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HiringDate d=new HiringDate(10,5,2024);
            Employee emp = new Employee(1, "ahmad", Security.Guest, 9473, d, Gender.M);
            Console.WriteLine(emp);
            Employee[] employees = new Employee[3];
        }
    }
}
