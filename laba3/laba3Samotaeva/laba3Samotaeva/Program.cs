using Samotaeva.Samotaeva;
using System;
using System.IO;
using System.Collections.Generic;


namespace Samotaeva
{
    class Program
    {
        static void Main(string[] args)
        {
            SolutionQuadraticEquation equations = new SolutionQuadraticEquation();
            Console.WriteLine("Введите a, b, c: ");
            try
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double b = Convert.ToDouble(Console.ReadLine());
                double c = Convert.ToDouble(Console.ReadLine());
                SamotaevaLog.getIntance().log("Введено уравнение " + a + "x^2 + " + b + "x + " + c);
                List<double> roots = equations.Solve(a, b, c);
                SamotaevaLog.getIntance().log("Корни уравнения: " + string.Join(" ", roots)).write();

            }
            catch (SamotaevaException e)
            {
                SamotaevaLog.getIntance().log(e.Message);
            }
            catch (IOException e)
            {
                throw new Exception("Outer", e);
            }
            SamotaevaLog.getIntance().write();
        }
    }
    }
