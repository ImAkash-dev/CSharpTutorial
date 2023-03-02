using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CClassTutorial
{
    public  class Institute
    {
        
        public string institutename { get; set; }
        public string Address { get; set; }
        public string Teachername { get; set; }
        public string Teacheraddress { get;set; }
        public int totalstudent { get; set; }
        public long Mobilenumber { get; set; }
        

        public void entry()
        {
            Console.WriteLine("firstly i am enter the institute");
        }
        public void study()
        {
            Console.WriteLine(" start the study");
        }
        public void submitfee()
        {
            Console.WriteLine("we submit the institute fee");
        }
    }
}
