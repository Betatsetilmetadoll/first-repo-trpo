using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class ClassB : ClassA
    {
        public void functiontwo(double a2, double b2, double c2)
        {
           double Discr = Math.Pow(b2, 2) - 4 * a2 * c2;
            if (Discr > 0 || Discr == 0)
            {
                double x1 = (-b2 + Math.Sqrt(Discr)) / (2 * a2);
                double x2 = (-b2 - Math.Sqrt(Discr)) / (2 * a2);
                Console.WriteLine("x1 = {0}\n x2 = {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("error");
                Console.ReadKey();
            }
            

        }
    }
}
