using System.Runtime.InteropServices;

internal class Program
{
    class MyMath
    {
        // int
        public int Abs(int input)
        {
            if (input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }

        // double
        public double Abs(double input)
        {
            if (input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }

        // long
        public long Abs(long input)
        {
            if (input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }
    }
    private static void Main(string[] args)
    {

        MyMath Mymath = new MyMath();

        // int
        Console.WriteLine(Mymath.Abs(52));
        Console.WriteLine(Mymath.Abs(-273));

        // double
        Console.WriteLine(Mymath.Abs(52.273));
        Console.WriteLine(Mymath.Abs(-32.103));

        // long
        Console.WriteLine(Mymath.Abs(21474836470));
        Console.WriteLine(Mymath.Abs(-21474836470));
    }
}