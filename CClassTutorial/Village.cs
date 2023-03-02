using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CClassTutorial
{
    internal class Village
    {
        public string name { get; set; }
        public string Address { get; set; }
        public int totalnoofroad { get; set; }
        public int totalnoofhouse { get; set; }
        public int population { get; set; }
       

        public void playing()
        {
            Console.WriteLine("We are  playing cricket in my village ");
        }
        public void walk()
        {
            Console.WriteLine("we are going to walk");
        }
    }
}
