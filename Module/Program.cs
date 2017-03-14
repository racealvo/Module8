using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    class Program
    {
        static void AddGrades(Student student, List<int> grades)
        {
            foreach (int grade in grades)
            {
                student.AddGrade(grade);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Teacher teacher = new Teacher("Stephen", "Hawking", new DateTime(1942, 1, 8));

                Student student1 = new Student("Johnny", "Doe", new DateTime(1998, 1, 1));
                Student student2 = new Student("Suzy", "Smith", new DateTime(1998, 1, 31));
                Student student3 = new Student("Debbie", "Downer", new DateTime(1998, 1, 15));

                Course course = new Course("Programming with C#", 3, 12);

                course.AddStudent(student1);
                course.AddStudent(student2);
                course.AddStudent(student3);
                course.AddTeacher(teacher);

                AddGrades(student1, new List<int> { 75, 90, 80, 81, 79 });
                AddGrades(student2, new List<int> { 95, 90, 93, 85, 89 });
                AddGrades(student3, new List<int> { 69, 75, 80, 71, 79 });

                Degree degree = new Module.Degree("Bachelor of Science", 30);
                degree.AddCourse(course);

                UProgram uProgram = new UProgram("Information Technology");

                Console.WriteLine("The {0} program contains the {1} degree.", uProgram.ProgramName, degree.DegreeName);
                Console.WriteLine("The {0} degree contains the course {1}.", degree.DegreeName, course.CourseName);
                Console.WriteLine("The school has {0} students enrolled.", Student.EnrolledStudents);

                Console.WriteLine("\n\nCourse {0} has the following students enrolled:", course.CourseName);
                course.ListStudents();

/*
                // Challenge 
                student1.ChangeLastGrade(100);

                Console.WriteLine("\nUpdate student grade.");
                student1.ChangeGrade(10, 1);
                course.ListStudents();
*/
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("Oops.  Please pardon our appearance.  This feature has not yet been implemented: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nHit any key to terminate the program.");
            Console.ReadKey();
        }
    }
}