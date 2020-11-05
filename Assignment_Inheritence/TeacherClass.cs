using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Inheritance
{
    public class TeacherClass
    {
        //TODO: inherit ParentBase class to this class
        public string Name { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        //TODO: Define methods here to initialize Salary, Experience, Name and age of a teacher
    }

    public class TeachersInformation
    {
        public List<TeacherClass> Teacherlist { get; set; }

        public TeachersInformation()
        {
            Teacherlist = new List<TeacherClass>();
        }

        public void display()
        {
            foreach (var teacher in Teacherlist)
            {
                Console.WriteLine(teacher.Name);
            }
        }
    }
}
