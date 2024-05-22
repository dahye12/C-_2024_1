// list,random 클래스 사용 
//실행결과) 
//  개수 10 
//count:10
// list: 11,23,45,56.....99
//--항목 삭제 후 ---
//count : 7
//list: 56,...99

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // 랜덤 클래스 생성, 랜덤 수 범위 0~99까지, 개수 입력받기
        Random r = new Random();            // 랜덤 수 클래스
        List<int> list = new List<int>();   // int형 리스트 생성

        // 랜덤 수 개수 입력받기
        Console.Write("랜덤 수 개수 입력 : ");
        int size = int.Parse(Console.ReadLine());

        // 랜덤 수 개수 출력
        Console.WriteLine("count : " + size);
        Console.WriteLine();

        // 랜덤 숫자를 입력받은 개수만큼 생성
        for (int i = 0; i < size; i++)
        {
            int randomNumber = r.Next(0, 100);      // 랜덤 수를 0~99 범위 중에서 생성하고
            list.Add(randomNumber);                 // 리스트에 랜덤 수를 추가
            Console.WriteLine((i + 1) + "번째 랜덤 수 요소 출력 : " + randomNumber);
        }

        Console.WriteLine();

        // 리스트로 출력
        foreach (var item in list)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine("\n");

        // 삭제할 요소 선택 받기
        Console.Write("삭제할 요소 입력 : ");
        int removeNum = int.Parse(Console.ReadLine());

        list.Remove(removeNum);     // 삭제

        // 삭제 된 요소 확인을 위한 현재 리스트 출력
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n");

        // 삭제할 범위 입력받기
        Console.Write("삭제할 범위 : ");
        int rangeNum = int.Parse(Console.ReadLine());

        list.RemoveRange(0, rangeNum);     // 삭제

        // 삭제 된 요소 확인을 위한 현재 리스트 출력
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
    }
}