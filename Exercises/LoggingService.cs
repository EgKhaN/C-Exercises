using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class LoggingService : IMathPerformedService
    {
        public void OnMathPerformed(object sender, MathPerformedEventArgs args)
        {
            Console.WriteLine("Logging result -> " + args.MathResult);
        }
    }
}
