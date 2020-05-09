using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Delegates
{
    public class MathService2
    {
        public event EventHandler<MathPerformedEventArgs> MathPerformed; // Type 3

        public double AddNumbers(double value1, double value2)
        {
            double result = value1 + value2;
            MathPerformed(this,new MathPerformedEventArgs(result)); //Type 3
            return result;
        }
        public double MultiplyNumbers(double value1, double value2)
        {
            double result = value1 * value2;
            MathPerformed(this, new MathPerformedEventArgs(result)); //Type 3
            return result;
        }
    }
}
