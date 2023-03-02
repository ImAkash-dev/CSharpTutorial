using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CClassTutorial
{
    internal class Bank2
    {
        public Bank2()
        {
            bankname = "PNB";
            Console.WriteLine("bank name is = " + bankname);
        }

    
    
        public string bankname { get; set; }
        public string address { get; set; }
        public int employid { get; set; }
        public string employname { get; set; }
        public string employaddress { get; set;}

        public void entry()
        {
            Console.WriteLine("We enter the bank ");
        }
        public void openbankaccoumt()
        {
            Console.WriteLine("Open Bank account ");
        }
        public void depositecash()
        {
            Console.WriteLine("Collect the cash ");
        }
         public void printpassbok()
        {
            Console.WriteLine("Print the Passbook");
        }

    }
}
