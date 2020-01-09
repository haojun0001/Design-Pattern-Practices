namespace SimpleFactory
{
    class Operation
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }

        public virtual double GetResult()
        {
            double result = 0d;
            return result;
        }
    }
}
