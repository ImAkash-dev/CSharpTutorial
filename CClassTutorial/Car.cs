using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CClassTutorial
{
    public class Car
    {

        public string name { get; set; }
        public string company { get; set; }
        public int model { get; set; }
        public int seats { get; set; }
        public double fuelcapacity { get; set; }
      



        public void openwindow() 
        {
            Console.WriteLine("firstly we open the window");
        }
        public void start() 
        {
            Console.WriteLine(" we start the car");
        }

        public void Race()
        {
            Console.WriteLine("now we took the race point");
        }
        public void speedup()
        {
            Console.WriteLine(" now we speed up");
        }
        public void speeddown() 
        {
            Console.WriteLine("now we speed down");
        }
        public void Break()
        {
            Console.WriteLine("we took the brak point");
        }
        public void stop()
        {
            Console.WriteLine("and now we stop the car");
        }
        public void openwindowAagain()
        {
            Console.WriteLine("we open window again ");
        }
        public void closewindow()
        {
            Console.WriteLine("and then close the window");
        }





    }
}