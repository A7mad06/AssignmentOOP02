using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Company
{
    enum Gender
    {
        Male = 1, male = 1, m = 1, M = 1, Female = 2, female = 2, F=2,f=2
    }
    enum Security
    {
        Guest, Developer, Secretary,DBA
    }
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Security SecurityLevel { get; set; }
        public double Salary { get; set; }
        public HiringDate HiringDate { get; set; }
        public Gender Gender { get; set; }

        public Employee()
        {
            Id = 0; 
            Name = null;
            Salary = 0;
        }
        public Employee(int Id,string Name,Security SecurityLevel,double Salary,HiringDate HiringDate,Gender Gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.SecurityLevel = SecurityLevel;
            this.Salary = Salary;
            this.HiringDate = HiringDate;
            this.Gender = Gender;
        }
        public override string ToString()
        {
            return String.Format("Id is {0},Name is {1},Security Level is {2},Salary is {3:C},Hiring Date is {4}, Gender is {5}",Id,Name,SecurityLevel,Salary,HiringDate,Gender);
        }
    }
}
