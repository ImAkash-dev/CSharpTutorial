using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CClassTutorial
{
    public class Company
    {
        public string Name { get; set; }
        public string address { get; set; }
        public int registratinnumber { get; set; }
        public int totalnumberofemploy { get; set; }
        

        public void work()
        {
            Console.WriteLine("we start the work in the company");
        }
        public void sallry()
        {
            Console.WriteLine("collect the sallary");
        }
    }
}
