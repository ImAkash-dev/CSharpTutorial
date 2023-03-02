using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CClassTutorial
{
    public class Bike
    {
     public string name { get; set; }
        public string company { get; set; }
        public int model { get; set; }
        public int fuelcapacity { get; set; }
        public int gear { get; set; }

        public void start()
        {
            Console.WriteLine("firstly we start the bike");
        }
        public void race()
        {
            Console.WriteLine("we start the race");
        }
        public void speedup()
        {
            Console.WriteLine("we speed up right now");
        }
        public void speeddown()
        {
            Console.WriteLine("now we speed down");
        }
        public void Break()
        {
            Console.WriteLine("we took the break");
        }
        public void stop()
        {
            Console.WriteLine("now we stop the bike");
        }

    }
}


