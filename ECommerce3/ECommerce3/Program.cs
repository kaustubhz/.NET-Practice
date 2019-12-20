using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;
using HRLibrary;

namespace ECommerce3
{
    class Program
    {
        static void Main(string[] args)
        {
         /*   complexNumOps();*/
           // Employee objPerson = new Employee();
            //Console.WriteLine("Person details \n"+objPerson);
            Employee objPerson = new SalesManager(1000,"Finance" ,40000);
            Console.WriteLine("Computed Salary is "+objPerson.computeSalary());
           /* if (objPerson is Employee)
                Console.WriteLine("Person is Employee");*/
            //Console.WriteLine("Employee details \n" + objPerson);

            //objPerson = new Manager("HR", 70000);

            //Console.WriteLine("Manager details \n" + objPerson);
            Console.ReadLine();
        }
        public static void complexNumOps()
        {
            Console.WriteLine("Inside Complex numbers");
            Complex c1 = new Complex(10, 20);
            Complex c2 = new Complex(30, 20);
            //Complex c7;
            /*Console.WriteLine("C1 is "+c1);*/
            //Console.WriteLine("The addition is "+c1+c2);

            Complex c3 = c1 + c2;
            Console.WriteLine("Addition of c1 and c2 is " + c3);
            Complex c4 = c1 - c2;
            Console.WriteLine("Subtraction of c1 and c2 is "+c4);
            Complex c5 = c1 * c2;
            Console.WriteLine("Multiplication of c1 and c2 is " + c5);
            Complex c6 = c1 / c2;
            Console.WriteLine("Division of c1 and c2 is " + c6);
        }
    }
}
