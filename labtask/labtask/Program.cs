using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentdetail
{
    class student
    {
        string name;
        string id;
        string department;
        float cgpa;

        public student()
        {
            Console.WriteLine("empty constructor");
        }
        public student(string name, string id, string department, float cgpa)
        {
            Console.WriteLine("parametrized constructor");
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;

        }
        internal void showdetails()
        {
            Console.WriteLine("student details ================================================");
            Console.WriteLine("name: " + name);
            Console.WriteLine("id : " + id);
            Console.WriteLine("department: " + department);
            Console.WriteLine("cgpa: " + cgpa);
            Console.WriteLine("student details ================================================");
        }
        static void Main(string[] args)
        {
            student obj = new student();
            student obj1 = new student("mahzabin mostary", "18-38606-2", "cse", 3.5f);
            obj1.showdetails();
        }
    }
}

