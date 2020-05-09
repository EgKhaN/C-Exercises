namespace Delegates
{
    public class MathService
    {
        public delegate double ResultHandler(double value1, double value2);
        public delegate void OutboundHandler(double result);

        public ResultHandler MathDelegate;
        public OutboundHandler OutBoundDelegate; //Type 1 -> Bunu event'e çevirebiliriz.
        public event OutboundHandler OutboundEvent; // Type 2
        
        public MathService()
        {
            MathDelegate = AddNumbers;
            MathDelegate += MultiplyNumbers;
        }
        private double AddNumbers(double value1, double value2)
        {
            double result = value1 + value2;
            //if (OutBoundDelegate != null) //Type 1
            //    OutBoundDelegate(result); //Type 1
            if (OutboundEvent != null) //Type 2
                OutboundEvent(result); //Type 2
            return result;
        }
        private double MultiplyNumbers(double value1, double value2)
        {
            double result = value1 * value2;
            //if (OutBoundDelegate != null) //Type 1
            //    OutBoundDelegate(result); //Type 1
            if (OutboundEvent != null) //Type 2
                OutboundEvent(result); //Type 2
            return result;
        }
    }
}
