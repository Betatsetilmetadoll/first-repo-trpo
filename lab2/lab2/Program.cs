using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double a, b;
            
            ClassA classa = new ClassA();
            {
                Console.WriteLine("a = ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("b = ");
                b = Convert.ToDouble(Console.ReadLine());

                classa.functionone(a,b);
                Console.ReadLine();

            }


            double a2;
            double b2;
            double c2;
            

            ClassB classb = new ClassB();

            Console.WriteLine("a = ");
            a2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("b = ");
            b2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("c = ");
            c2 = Convert.ToDouble(Console.ReadLine());

            classb.functiontwo( ref a2, ref b2, ref c2);
            Console.ReadLine();

        }
    }
 
}
