using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CClassTutorial
{

    public class Bank
    {
        
        public string name { get; set; }
        public string Branch { get; set; }
        public int NumberOfEmployees { get; set; }


        public void Accountopen() {
            Console.WriteLine("Open my account");
        }
        public void PaasBookprint() {
            Console.WriteLine("print my passbook");
        }
        public void CashDeposite() {
            Console.WriteLine("Deposit cash in my account");
        }

        public void BalanceCheck() {
            Console.WriteLine("Checked my balance");
        }
        


    }
}
