using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CClassTutorial
{
    internal class Hospital
    {
        public string name { get; set; }
        public string address { get; set; }
        public string Deanname { get; set; }
        public int totalnumberofdocter { get; set; }
        public int totalnumberofflour { get; set; }
        public int totalrooms { get; set; }

        public void appointment()
        {
            Console.WriteLine("Appointment to Doctor");
        }
        public void Medicine()
        {
            Console.WriteLine("Collect the Medicine");
        }
        public void submitbill()
        {
            Console.WriteLine("submit the medicine bill ");
        }
        public void backtohome()
        {
            Console.WriteLine("And then back to home");
        }

    }
}
