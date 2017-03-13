using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    class Student : Person
    {
        private static int enrolledStudents;

        public static int EnrolledStudents {
            get { return enrolledStudents; }
        }

        public Student(string first, string last, DateTime date) : base(first, last, date)
        {
            enrolledStudents++;
        }

        public override void PrepareForClass()
        {
            Console.WriteLine("Review reading assignments and do homework.");
        }

        public void TakeTest()
        {
            Console.WriteLine("Take test (Yikes).");
        }

        public void GoToLibrary()
        {
            Console.WriteLine("Go to the library.");
        }

        public override void GoAboutMyDay()
        {
            PrintBio();
            PrepareForClass();
            TakeTest();
            GoToLibrary();
        }

        private Stack grades = new Stack();

        public void AddGrade(int grade)
        {
            grades.Push(grade);
        }

        public Stack GetGrades()
        {
            Stack temp = new Stack();

            foreach(int grade in grades)
            {
                temp.Push(grade);
            }

            return temp;
        }

        public bool EnsureGradeCount(int expectedNumberOfGrades)
        {
            return (grades.Count == expectedNumberOfGrades);
        }

        public void ChangeLastGrade(int newGrade)
        {
            grades.Pop();
            grades.Push(newGrade);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newGrade"></param>
        /// <param name="gradePosition">zero based value - which grade to change</param>
        public bool ChangeGrade(int newGrade, int gradePosition)
        {
            bool gradeChanged = false;

            // grade position must be within range.
            if ((gradePosition > grades.Count) || (gradePosition < 0))
            {
                return gradeChanged;
            }

            Stack oldGrades = new Stack();
            int iterations = grades.Count-gradePosition;

            for(int i=0; i<iterations; i++)
            {
                int grade = (int) grades.Pop();
                oldGrades.Push(grade);
            }

            // toss the old grade out - this is the one being changed.
            oldGrades.Pop();
            grades.Push(newGrade);

            foreach(int grade in oldGrades)
            {
                grades.Push(grade);
            }

            return gradeChanged;
        }
    }
}
