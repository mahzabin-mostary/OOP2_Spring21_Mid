using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicated2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, ctr = 0;
            int[] arr1 = new int[100];
            int i, j, k;

            Console.Write(" elements of an array:\n");
          
            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("array ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
       
            
            for (i = 0; i < n; i++)
            {
                ctr = 0;
             
                for (j = 0; j < i - 1; j++)
                {
                    
                    if (arr1[i] == arr1[j])
                    {
                        ctr++;
                    }
                }
              
                for (k = i + 1; k < n; k++)
                {
                 
                    if (arr1[i] == arr1[k])
                    {
                        ctr++;
                    }
              
                    if (arr1[i] == arr1[i + 1])
                    {
                        i++;
                    }
                }
                
                if (ctr == 0)
                {
                    Console.Write("{0} ", arr1[i]);
                }
            }
            Console.Write("unique element");
        }
    }
}
    
