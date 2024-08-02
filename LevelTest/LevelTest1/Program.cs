namespace LevelTest1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int iLeft = 10;
            int iRight = 20;
            Util.Swap(ref iLeft, ref iRight);
            Console.WriteLine("int 자료형을 사용한 Swap 함수");
            Console.WriteLine($"{iLeft}  {iRight}");

            Console.WriteLine();

            double dLeft = 3.5;
            double dRight = 8.8;
            Util.Swap(ref dLeft, ref dRight);
            Console.WriteLine("double 자료형을 사용한 Swap 함수");
            Console.WriteLine($"{dLeft}  {dRight}");

            Console.WriteLine();

            string sLeft = "Left";
            string sRight = "Right";
            Util.Swap(ref sLeft, ref sRight);
            Console.WriteLine("string 자료형을 사용한 Swap 함수");
            Console.WriteLine($"{sLeft}  {sRight}");
        }
    }
    public static class Util
    {
        public static void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }
        public static void Swap(ref long left, ref long right)
        {
            long temp = left;
            left = right;
            right = temp;
        }
        public static void Swap(ref float left, ref float right)
        {
            float temp = left;
            left = right;
            right = temp;
        }
        public static void Swap(ref double left, ref double right)
        {
            double temp = left;
            left = right;
            right = temp;
        }
        public static void Swap(ref char left, ref char right)
        {
            char temp = left;
            left = right;
            right = temp;
        }
        public static void Swap(ref string left, ref string right)
        {
            string temp = left;
            left = right;
            right = temp;
        }
    }

}
