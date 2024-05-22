
// int[] array = new array[100] 어레이 연산자가 100개잇는임/ p163 new써서 배열 2줄 생성하고 입력 반복문 while로 그러고 for로 바꿔서해봐라, 출력

internal class Program
{
    private static void Main(string[] args)
    {
         int i = 0; //초기화 변수
        int[] array = new int [ 5 ]; //배열선언 5개를 5로
        
        while( i < array.Length)
        {
            Console.WriteLine($"{i}번째 입력 : ");
            array[i]= int.Parse(Console.ReadLine());
            i++;

        }
        Console.WriteLine();

        for(i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"{i}번째 출력 : {array[i]}");
        }

    }
}