internal class Program // 리스트 클래스 랜덤 클래스 둘다 쓰기 5-3 리무브 하나 지워보고 
{
    private static void Main(string[] args)
    {
       //변수를 선언합니다. 
       List<int> list = new List<int>();

    // 리스트에 요소를 추가합니다 
    list.Add(52);
    list.Add(273);
    list.Add(32);
    list.Add(64);

    // 반복을 수행합니다.
    foreach (var item in list)
        {
            Console.WriteLine("Count:" + list.Count + "\titem:" + item);
        }
    }
}
