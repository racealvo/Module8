using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime BirthDate { get; }

        public Person(string first, string last, DateTime date)
        {
            this.FirstName = first;
            this.LastName = last;
            this.BirthDate = date;
        }

        public void PrintBio()
        {
            Console.WriteLine("{0} {1} born on {2}", FirstName, LastName, BirthDate.ToString());
        }

        public virtual void PrepareForClass()
        {
            Console.WriteLine("Prepare for class.");
        }

        public virtual void GoAboutMyDay()
        {
            PrepareForClass();
        }
    }
}
