using System;
using System.Collections.Generic;
using System.Text;



namespace Assignment_Inheritance
{
    public class PersonClass
    {
        public string PropData { get; set; }
        public string StdName { get; set; }
        public int StdClass { get; set; }
        public int StdAge { get; set; }
        public int StdAverage { get; set; }
        public string TrName { get; set; }
        public int TrAge { get; set; }
        public string TrDesignation { get; set; }
        public int TrExperience { get; set; }
        public int TrSalary { get; set; }



    }
    public class PersonInformation
    {
        public List<PersonClass> Personlist { get; set; }

        public PersonInformation()
        {
            Personlist = new List<PersonClass>();
        }
    }
}
