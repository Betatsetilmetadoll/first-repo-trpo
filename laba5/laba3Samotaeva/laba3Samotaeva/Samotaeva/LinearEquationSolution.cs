using System;
using System.Collections.Generic;
using System.Text;

namespace Samotaeva.Samotaeva
{
    class LinearEquationSolution 
    {
        protected List<double> X;
        public List<double> LinearEquation(double a, double b)
        {

            if (a == 0)
                
            SamotaevaLog.getIntance().log("Данное уравнение не имеет решений!");
            SamotaevaLog.getIntance().log("Определено, это линенйное уравнение");


            return X = new List<double> { -b / a };
         

        }
    }
}
