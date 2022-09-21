namespace Practice
{
    public class Calculator : ICalculator
    {
        ILogger Logger { get; }

        public void Calculate(double x, double y)
        {
            var result = Math.Round(x + y, 14);
            Logger.Event($"Результат: {result}");
        }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }
    }
}
