//for와 while차이점,
//누적의 합을구하는 변수는 무조건 0으로 초기화 
// 한글은 한자 다음으로 많은 글자수 

//p.168 정수 두개 입력받고, 입력 받은 문자부터 입력 받은 문자까지
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("시작 문자 : ");
        char start = char.Parse(Console.ReadLine());

        Console.Write("마지막문자 : ");
        char end = char.Parse(Console.ReadLine());

        for(int i = start; i <=end; i++)
        {
            Console.Write($"{ (char) i, -3}"); 
        }

    }
}
       