namespace Static
{
    internal class Program
    {
        class MyCalculator
        {
            static public double Add(double a, double b)
            {
                return a + b; 
            }
            static public double Subtract(double a, double b)
            {
                return a - b;
            }
            static public double Multiply(double a, double b)
            {
                return a * b;
            }
            static public double Divide(double a, double b)
            {
                if (b == 0)
                {
                    Console.Write("에러 발생: ");
                    return a/b;
                }
                return a / b;
            }
            static public double Squared(double a, double b) 
            {
                return Math.Pow(a,b);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyCalculator.Add(1.1, 3.3));
            Console.WriteLine(MyCalculator.Subtract(5,1));
            Console.WriteLine(MyCalculator.Multiply(3,4));
            Console.WriteLine(MyCalculator.Divide(3,0));
            Console.WriteLine(MyCalculator.Squared(2,5));
        }
    }
}
