using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CClassTutorial
{
    internal class Student
    {

        // default constructor

        //public Student()
        //{
        //    Console.WriteLine("Defualt Constructor called");

        //}

        // parameterized constructor
        //public Student(long phone, string fname, string lname)
        //{

        //    mobile = phone;
        //    firstname = fname;
        //    lastname = lname;
        //}

        // static constructor

        //static Student()
        //{
        //    Console.WriteLine("Static Constructor called");
        //    Age = 22;
        //    Address = "Purkaji MZN";
        //}

        // copy constructor

        //public Student(Student student)
        //{
        //    Console.WriteLine("Copy Constructor called");
        //    Age = 40;

        //    Id = student.Id;
        //    firstname = student.firstname;
        //    lastname = student.lastname;
        //    mobile = student.mobile;

        //}

        // private constructor

        //private Student()
        //{
        //    Console.WriteLine("Private Constructor called");

        //}


        public int Id { get; set; } 
        public string firstname{ get; set; }
        public string lastname { get; set; }
        public long mobile{ get; set; }

        static string Address { get; set; }

        public static int Age { get; set; }

         public static void PrintName(string firstname, string lastname)
        {
            Console.WriteLine(firstname + " " + lastname);
        }
        public void study()
        {
            Console.WriteLine("i study");
        }
        public void playing()
        {
            Console.WriteLine("playing cricket");
        }

    }
}
