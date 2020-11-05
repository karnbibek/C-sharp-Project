using System;
using System.Data;
using System.Xml;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Assignment_Inheritance
{
    class Program
    {
        private const string T = "Teacher";
        private const string S = "Student";
        static void Main(string[] args)
        {
            //Parse the XML file SchoolInfo.xml present in solution folder, This xml file has several records of students and teachers. 
            //Create a dynamic list and store both students and teachers information in this dynamic list
            //While parsing, students information shall be stored in object of StudentClass and Teachers information in object of TeacherClass.
            //Finally There has to be a list which contains objects of both StudentsClass and TeachersClass, these objects contain 
            //information present in xml file.
            //Once parsing is done, run a loop through the list and print all details of each objects of the list.

            //Hint: You may have to use Inheritance
            //Console.WriteLine("Hello World!");
            List<TeacherClass> teacherlist = new List<TeacherClass>();
            List<StudentClass> studentsList = new List<StudentClass>();
            List<PersonClass> personList = new List<PersonClass>();


            XmlTextReader xtr = new XmlTextReader(@"E:\Assignment_Inheritence\Assignment_Inheritence\SchoolInfo.xml");

            while (xtr.Read())
            {
                var persons = new PersonClass();
                switch (xtr.Name.ToString())
                {

                    case T:
                        {

                            var teachers = new TeacherClass();
                            while (xtr.Read())
                            {
                                if (xtr.Name == "Name")
                                {
                                    string s1 = xtr.ReadElementString();
                                    teachers.Name = s1;
                                    persons.TrName = s1;
                                }
                                if (xtr.Name == "Age")
                                {
                                    int s2 = xtr.ReadElementContentAsInt();
                                    teachers.Age = s2;
                                    persons.TrAge = s2;
                                }
                                if (xtr.Name == "Designation")
                                {
                                    string s3 = xtr.ReadElementString();
                                    teachers.Designation = s3;
                                    persons.TrDesignation = s3;
                                }
                                if (xtr.Name == "Experience")
                                {
                                    int s4 = xtr.ReadElementContentAsInt();
                                    teachers.Experience = s4;
                                    persons.TrExperience = s4;
                                }
                                if (xtr.Name == "Salary")
                                {
                                    int s5 = xtr.ReadElementContentAsInt();
                                    teachers.Salary = s5;
                                    persons.TrSalary = s5;
                                }
                                if (xtr.Name == T)
                                {
                                    persons.PropData = "Teacher";
                                    personList.Add(persons);
                                    //teacherList.Add(teachers);
                                    break;
                                }                                
                            }
                        }
                        break;
                    case S:
                        {
                            var students = new StudentClass();
                            while (xtr.Read())
                            {
                                if (xtr.Name == "Name")
                                {
                                    string s6 = xtr.ReadElementString();
                                    students.Name = s6;
                                    persons.StdName = s6;
                                }
                                if (xtr.Name == "Class")
                                {
                                    int s7 = xtr.ReadElementContentAsInt();
                                    students.Class = s7;
                                    persons.StdClass = s7;
                                }
                                if (xtr.Name == "Age")
                                {
                                    int s8 = xtr.ReadElementContentAsInt();
                                    students.Age = s8;
                                    persons.StdAge = s8;
                                }
                                if (xtr.Name == "Average")
                                {
                                    int s9 = xtr.ReadElementContentAsInt();
                                    students.Average = s9;
                                    persons.StdAverage = s9;
                                }
                                if (xtr.Name == S)
                                {
                                    persons.PropData = "S";
                                    //studentsList.Add(students);
                                    personList.Add(persons);
                                    break;
                                }                                
                            }
                        }
                        break;
                }
            }

            foreach (var person in personList)
            {
                if(person.PropData == "Teacher")
                {
                    Console.WriteLine("Name : " + person.TrName);
                    Console.WriteLine("Age : " + person.TrAge);
                    Console.WriteLine("Designation : " + person.TrDesignation);
                    Console.WriteLine("Experience : " + person.TrExperience);
                    Console.WriteLine("Salary : " + person.TrSalary);
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Name : " + person.StdName);
                    Console.WriteLine("Class : " + person.StdClass);
                    Console.WriteLine("Age : " + person.StdAge);
                    Console.WriteLine("Average : " + person.StdAverage);
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("\n");
                }    
            }
        }
    }
}