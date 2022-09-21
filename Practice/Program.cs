using System.Security.Cryptography.X509Certificates;

namespace Practice
{
    class Program
    {
        static ILogger Logger { get; set; }

        static void Main()
        {
            Logger = new Logger();
            Calculator calculator = new(Logger);

            Console.WriteLine("Введите числа для сложения:");
            try
            {
                var x = Double.Parse(Console.ReadLine());
                var y = Double.Parse(Console.ReadLine());
                
                calculator.Calculate(x, y);
            }
            catch(Exception e) when (e is FormatException)
            {
                Logger.Error("Некорректный фомат ввода.");
            }
            catch(Exception e)
            {
                Logger.Error(e.Message);
            }
        }
    }
}
