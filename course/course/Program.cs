using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    class course
    {
        string coursename;
        string coursecode;
        string coursecredit;


        public course()
        {
            Console.WriteLine("empty constructor");
        }
        public course(string coursename, string coursecode, string coursecredit)
        {
            Console.WriteLine("parametrized constructor");
            this.coursename = coursename;
            this.coursecode = coursecode; ;
            this.coursecredit = coursecredit;
           
        }
        internal void courseinfo()
        {
            Console.WriteLine("course details ================================================");
            Console.WriteLine("name: " + coursename);
            Console.WriteLine("coursecode : " + coursecode);
            Console.WriteLine("coursecredit: " + coursecredit);
           
            Console.WriteLine("course details ================================================");
        }
        static void Main(string[] args)
        {
            course obj = new course();
            course obj1 = new course("opp2","3211","15");
            obj1.courseinfo();
        }
    }
}
