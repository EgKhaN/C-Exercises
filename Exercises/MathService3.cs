using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Delegates
{
    public class MathService3
    {
        //bu iki satır yerine Action yazabiliriz.
        //public delegate void MathPerformedHandler(double result);
        //public event MathPerformedHandler MathPerformed;

        //Yukarıdaki 2 satırın tek satır halie
        public Action<double> MathPerformed;

        //bu satır yerine de Func yazıp direk fonksiyona parametre olarak vereebiliriz
        public delegate double CalculationHandler(double value1, double value2);

    
        public void Calculate(double value1, double value2, CalculationHandler calculate)
        {
            MathPerformed(calculate(value1,value2));
        } 
        public void Calculate2(double value1, double value2, Func<double,double,double> calculate)
        {
            MathPerformed(calculate(value1,value2));
        }
        
    }
}
