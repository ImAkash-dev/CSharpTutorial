using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CClassTutorial
{
    public class Studentconstructor
    {
        
        public Studentconstructor()
        {
            schoolname = "DAV";
            Console.WriteLine("school name is = " + schoolname);
        }
        public string name { get; set; }
        public int ID { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string schoolname { get; set; }

        public void entry()
        {
            Console.WriteLine("enter the college ");
        }
        public void study()
        {
            Console.WriteLine("start study" );
        }
     
    }
}
