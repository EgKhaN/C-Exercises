using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example1(); //Delegate
            //Example2(); //Event
            //Example3(); //Event Handler
            //Example4(); //Interface
            Example5(); // Calculation'ı client'a inverse ettik

        }
        private static void Example5()
        {
            MathService3 mathService = new MathService3();
            mathService.MathPerformed += (result) => Console.WriteLine("result ="+result);
            mathService.Calculate(3, 4, (x, y) => x * y);
        }
            private static void Example4()
        {
            MathService2 mathService = new MathService2();
            new List<IMathPerformedService> { new LoggingService(), new NotificationService() }.ForEach(serv => mathService.MathPerformed += serv.OnMathPerformed);
            mathService.AddNumbers(3, 4);
            mathService.MultiplyNumbers(3, 4);
        }
        private static void Example3()
        {
            MathService2 mathService = new MathService2();
            mathService.MathPerformed += OnOutboundEvent;
            mathService.AddNumbers(3, 4);
            mathService.MultiplyNumbers(3, 4);
        }
        static void OnOutboundEvent(object sender , MathPerformedEventArgs args)
        {
            Console.WriteLine("Result = " + args.MathResult);
        }
            private static void Example2()
        {
            MathService mathService = new MathService();
            mathService.OutboundEvent += OnOutboundDelegate;
        }

        private static void Example1()
        {
            MathService mathService = new MathService();
            //mathService.OutBoundDelegate += (result) => Console.WriteLine("Result = " + result);
            //mathService.OutBoundDelegate = delegate(double result) { Console.WriteLine("Result = " + result); };
            /*-> Bu Bildiğin event*/
            mathService.OutBoundDelegate = OnOutboundDelegate;
            mathService.MathDelegate(3, 4);
            //Console.WriteLine(result);
        }
        static void OnOutboundDelegate(double result)
        {
            Console.WriteLine("Result = " + result);
        }
    }
}
