internal class Program
{
    private static void Main(string[] args) // 아까 랜덤문제에서 사진 6번임 0~99 사이, 최대최소값출력(max.min 사용 x)

    {
        Random r = new Random();
        Console.Write("랜덤개수 :");
        int size = int.Parse(Console.ReadLine());
        int[] intArray = new int[size];

        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = r.Next(0, 99); // 0-99까지 숫자 

            for (int j = 0; j < i; j++)
            {
                if (intArray[j] == intArray[i])  //0부터 늘 비교를 해야돼 i밑에까지 // 비교해서 같으면 다시받아라
                    i--; // i똑같으면 증가하면 안되니까 i를 뺴줘 index가 변화가없다 줄엿다가 다시 증가하면 현재 인덱스 
            }
        }

        Console.WriteLine("생성된" + size + "개의 랜덤한 숫자 출력: ");


        foreach (var value in intArray)
            Console.Write("{0,5}", value); // -5면 왼쪽정렬, 5면 오른쪽정렬

        int min = intArray[0];
        int max = intArray[0];
        for (int i = 0; i < intArray.Length - 1; i++)
        {
            if (max < intArray[i + 1]) max = intArray[i + 1];
            if (min > intArray[i + 1]) min = intArray[i + 1];



        }

        Console.WriteLine($"\n최대값 : {max}\n최소값 : {min} ");
    }
}