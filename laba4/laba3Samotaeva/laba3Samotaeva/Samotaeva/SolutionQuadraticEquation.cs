using System;
using System.Collections.Generic;
using Core;
using System.Text;


namespace Samotaeva.Samotaeva
{
    class SolutionQuadraticEquation : LinearEquationSolution, EquationInterface
    {

        // List<double> list;
        protected double qua(double a, double b, double c)
        {
            return b * b - (4 * a * c);
        }

        public List<double> Solve(double a, double b, double c)
        {

            if (a == 0)
            {
                return X = LinearEquation(b, c);
            }
            SamotaevaLog.getIntance().log("Определено, это квадратное уравнение");

            double D = qua(a, b, c);

            if (D < 0)
            {
                SamotaevaLog.getIntance().log("Действительных корней нет");
            }

            if (D == 0)
            return X = new List<double>() { (-b) / (2 * a) };

            D = (double)Math.Sqrt(D);//-b/(2a) - D/(2a)
            //c = 
            return X = new List<double>() {
                (-b + D) / (2 * a),
                (-b - D) / (2 * a)
            };

        }

    }
}
