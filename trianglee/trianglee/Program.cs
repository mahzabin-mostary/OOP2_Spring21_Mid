using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trianglee { 
  class triangle
{
   
    int x;
    int y;
    int z;

    public triangle()
    {
        Console.WriteLine("empty constructor");
    }
    public triangle( int x, int y,int z)
    {
        Console.WriteLine("parametrized constructor");
        this.x = x;
        this.y = y;
        this.z = z;
 

    }
    internal void showdetails()
    {
        Console.WriteLine(" details ================================================");
        Console.WriteLine("x: " + x);
        Console.WriteLine("y : " + y);
        Console.WriteLine("z: " + z);
      
        Console.WriteLine("details ================================================");
    }
    static void Main(string[] args)
    {
        triangle obj = new triangle();
        triangle obj1 = new triangle(10,10, 10);
        obj1.showdetails();
    }
}
}