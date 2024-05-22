internal class Program
{
    private static void Main(string[] args)
    {
        

        Console.WriteLine("정수 두개를 입력하세요 :");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("연산자를 입력하세요(+-*/% : ");
        string op = Console.ReadLine();
        
        switch (op)
        {
            case "+":
                Console.WriteLine($" {a} + {b} = {a + b}");
            break;
            case "-":
                Console.WriteLine($" {a} - {b} = {a - b}");
            break;
            case "*":
                Console.WriteLine($" {a} * {b} = {a * b}");
                break;
            case "/":
                Console.WriteLine($" {a} * {b} = {a * b}");
                break;

        }
    }
}