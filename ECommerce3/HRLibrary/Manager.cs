using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Manager:Employee
    {
        private String department;

        public Manager(string department,double empSal):base(empSal)
        {
            this.department = department;
        }

        public override string ToString()
        {
            return base.ToString()+"Department [ "+department+" ]";
        }

        public override double computeSalary()
        {
            throw new NotImplementedException();
        }

        ~Manager()
        {
            Console.WriteLine("Inside " + GetType().Name + " DTOR");
        }
    }
}
