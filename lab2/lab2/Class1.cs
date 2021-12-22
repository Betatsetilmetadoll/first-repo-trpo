using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class ClassA
    {
        
        public void functionone (double a, double b)
        {
            if (a==0)
            {
                Console.WriteLine("error");
            }

            
             double x = (-b / a);
            Console.WriteLine("x = {0}\n", x);
        }
        

    }
}
