using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student2
{
  { 
    class student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private student[] sudents;
        private int studentcount;
         private int Studentcount
        {
            get { return studentcount; }
            set { studentcount = value; }
        }
        public student() { }

        public student(string name, string id)
        {
            this.name = name;
            this.id = id;

        }

        Department department;

        public Department Department
        {
            get { return department; }
            set { department = value; }
        }
        public void addstudent(Student student)
        {

        }
        public void showinfo()
        {
            Console.WriteLine("......................");
            Console.WriteLine("name=" + name);
            Console.WriteLine("id=" + id);
        }
        static void Main(string[] args)
        {
            Department d1 = new Department { "computer of eng", "coa" };
            Department d2 = new Department { "computer sc", "cse" };
            student s1 = new student("monisha", "111");
            s1.Department = d2;
            s1.showinfo();
            s2.Department();
            Console.WriteLine(s1.Department.name);
        }
    }
}
