using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class NotificationService : IMathPerformedService
    {
        public void OnMathPerformed(object sender, MathPerformedEventArgs args)
        {
            Console.WriteLine("Notification result -> " + args.MathResult);
        }
    }
}
