using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    class Teacher : Person
    {
        public Teacher(string first, string last, DateTime date) : base(first, last, date)
        { }

        public override void PrepareForClass()
        {
            Console.WriteLine("Write up lecture, slides and practice.");
        }

        public void GradeTest()
        {
            Console.WriteLine("Grade test (boring).");
        }

        public void AttendFacultyMeeting()
        {
            Console.WriteLine("Attend faculty meeting.");
        }

        public override void GoAboutMyDay()
        {
            PrintBio();
            PrepareForClass();
            GradeTest();
            AttendFacultyMeeting();
        }
    }
}
