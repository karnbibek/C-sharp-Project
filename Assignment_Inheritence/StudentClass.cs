using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Inheritance
{
    public class StudentClass
    {
        //TODO: inherit ParentBase class to this class
        public string Name { get; set; }
        public int Class { get; set; }
        public int Age { get; set; }
        public int Average { get; set; }



        //TODO: define methods to initialize Averagemarks, classStudying, name and age of student
    }
    public class StudentsInformation
    {
        public List<StudentClass> Studentlist { get; set; }

        public StudentsInformation()
        {
            Studentlist = new List<StudentClass>();
        }
    }
}
