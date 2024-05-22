internal class Program
{
    private static void Main(string[] args)
    {
        Random r = new Random();
        Console.Write("랜덤개수 :");
        int size = int.Parse(Console.ReadLine());
        int[] intArray = new int[size];

        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = r.Next(1, 46); // 1-45까지 숫자 

            for (int j = 0; j < i; j++)
            {
                if (intArray[j] == intArray[i])  //0부터 늘 비교를 해야돼 i밑에까지 // 비교해서 같으면 다시받아라
                    i--; // i똑같으면 증가하면 안되니까 i를 뺴줘 index가 변화가없다 줄엿다가 다시 증가하면 현재 인덱스 
            }
        }

        Console.WriteLine("생성된" + size + "개의 랜덤한 숫자 출력: ");

        foreach (var value in intArray)
            Console.WriteLine("{0,3}", value);
    }
}