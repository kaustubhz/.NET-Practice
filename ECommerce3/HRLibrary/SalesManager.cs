using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class SalesManager : Manager
    {
        private int salesTarget;

        public SalesManager(int salesTarget,String department,double empSalary):base(department,empSalary)
        {
            this.salesTarget = salesTarget;
        }

        ~SalesManager()
        {
            Console.WriteLine("Inside DTOR of "+GetType().FullName);
        }

        public override double computeSalary()
        {
            return base.EmpSalary + 5000;
        }

        public override string ToString()
        {
            return base.ToString()+" Sales Target [ "+salesTarget+" ]";
        }
    }
}
