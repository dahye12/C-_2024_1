internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("월을 입력하세요");
        string input = Console.ReadLine();
        int num = int.Parse(input);

        if (num == 1 || num == 2 || num == 12) 
        {
            Console.WriteLine("겨울입니다.");
        }
        else if (num ==3 ||  num == 4 || num == 5) 
        {
            Console.WriteLine("봄입니다.");
         }
        else if (num == 6 || num == 7 || num == 8)
        {
            Console.WriteLine("여름입니다.");
        }
        else if (num == 9 || num == 10 || num == 11)
        {
            Console.WriteLine("가을입니다.");
        }
        else
        Console.WriteLine("잘못입력했습니다." );
    }
    }
