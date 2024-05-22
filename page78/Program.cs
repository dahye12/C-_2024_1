internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" 현재Hour : " + DateTime.Now.Hour); 
        Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
        Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);


        int a = 2147483640;
        int b = 52273;

        Console.WriteLine(a + b);

        //int 자료형의 최댓값과 최솟값
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(int.MinValue);
        //long 자료형의 최댓값과 최솟값 
        Console.WriteLine(long.MaxValue);
        Console.WriteLine(long.MinValue);

        // 연결연산자를 잘 쓰는 예, x + Y를 x + y 말고 10+6으로 나타내기  
        // colsole/WriteLine("x + y = " (x + y)) 말고 
        // 나누기 앞에 float이나 double 붙이면 나머지나옴 , %는 나머지 
        int x = 10, y = 6;

        Console.WriteLine(x + y);

        Console.WriteLine(x + "+" + y + "=" + (x+y));
        Console.WriteLine(x + "-" + y + "=" + (x - y));
        Console.WriteLine(x + "/" + y + "=" + ((float)x / y));
        Console.WriteLine(x + "*" + y + "=" + (x * y));
        Console.WriteLine(x + "%" + y + "=" + (x % y));
    }
}