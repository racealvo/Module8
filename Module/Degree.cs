using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    class Degree
    {
        private Course course;

        // Degree Info
        public string DegreeName { get; set; }
        public int CreditsRequired { get; private set; }

        public Degree(string degree, int credits)
        {
            DegreeName = degree;
            CreditsRequired = credits;
        }

        public bool AddCourse(Course course)
        {
            this.course = course;

            return true;
        }
    }
}
