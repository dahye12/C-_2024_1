// 입력한 숫자의 합계와 평균을 출력하는 프로그램
// - 0~10 사이의 수만 입력 가능
// - 평균은 소수점 이하 2자리 까지 출력

internal class Program
{
    private static void Main(string[] args)
    {
        // 1. 입력할 숫자 개수 입력받기
        Console.Write("입력할 숫자의 개수 : ");
        int num = int.Parse(Console.ReadLine());
        int result = 0; // 누적의 합을 저장할 변수 0으로 초기화

        Console.WriteLine();

        Console.WriteLine("0~10 사이의 수만 입력하세요.");

        // 2. 개수만큼 입력받기
        for (int i = 0; i < num; i++)
        {
            Console.Write($"{i + 1}번째 : ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0 || number > 10)    // 입력받은 숫자가 0~10 범위의 값이 아니라면
            {
                Console.WriteLine("유효한 수가 아님! 다시 입력하세요.");
                i--;
            }

            else
            {
                result += number;   // 입력받은 값 누적하기
            }
        }

        // 3. 출력하기
        Console.WriteLine($"합계 : {result}");
        Console.WriteLine($"평균 : {result / num:F2}");

    }
}