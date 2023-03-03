using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CClassTutorial
{
    public class Animal
    {
        public string name { get; set; }
        public int legs { get; set; }
        public double weight { get; set; }
        public int age { get; set; }
        public bool nonveg { get; set; }

        public void sleep()
        {
            Console.WriteLine("he sleep");
        }
        public void run()
        {
            Console.WriteLine("he can run");
        }
        public void eat()
        {
            Console.WriteLine("he can eat");
        }
    }
    public class Lion : Animal
    {
        public void  hunts()
        {
            Console.WriteLine(" Lion hunts");
        }

    }
}

