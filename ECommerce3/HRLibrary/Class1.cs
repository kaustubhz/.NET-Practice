using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Person
    {
        private String firstName;
        private String lastName;
        private DateTime birthDate;
        private String email;
        private String location;


        public Person()
        {
            this.FirstName = "Vinit";
            this.LastName = "Pardhi";
            this.BirthDate = new DateTime(1992,09,24);
            this.Email = "vinit@gmail.com";
            this.Location = "Pune";
        }
        public Person(string firstName, string lastName, DateTime birthDate, string email, string location)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Email = email;
            this.Location = location;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Email { get => email; set => email = value; }
        public string Location { get => location; set => location = value; }

        public override string ToString()
        {
            return "Person [ "+FirstName+","+LastName+"," + BirthDate + "," + Email + "," + Location +" ]";
        }
        ~Person()
        {
            Console.WriteLine("Inside DTOR");
        }
    }


}
