using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CClassTutorial
{
    public class Vehicle
    {
        public string name { get; set; }
        public int model { get; set; }
        public string company { get; set; }
        public int Windows { get; set; }
       
        public int tyers { get; set; }

        private void OpenEngine()
        {
            Console.WriteLine("only parent class can do this");
        }
        public void start()
        {
            Console.WriteLine(" we start the car");
        }
        public void race()
        {
            Console.WriteLine("we start race");
        }
        public void speedup()
        {
            Console.WriteLine(" now speedup");
        }
        public void speeddown()
        {
            Console.WriteLine(" then speeddown");
        }
        public void Break()
        {
            Console.WriteLine(" break");
        }
        public void stop()
        {
            Console.WriteLine(" we stop the car");
        }
    }

       public class Carr :Vehicle
            {
                public void openwindows()
                {
                    Console.WriteLine("Open the window");
                }
            }
}
