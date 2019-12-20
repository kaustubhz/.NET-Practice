using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public abstract class Employee:Person
    {
        private double empSalary;

        public double EmpSalary { get => empSalary; set => empSalary = value; }

        public Employee(double empSalary):base("Kaustubh","Zagade",new DateTime(1996,11,30),"kaustubh@gmail.com","Pune")
        { 
            this.EmpSalary = empSalary;
        }

        public override string ToString()
        {
            return base.ToString()+"Salary [ "+EmpSalary+" ]";
        }
        public abstract double computeSalary();

        ~Employee()
        {
            Console.WriteLine("Inside Employee DTOR");
        }
    }
}
