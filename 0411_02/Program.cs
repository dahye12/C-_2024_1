internal class Program
{
    class Product
    {
        public string name;
        public int price;

        public void output()        // 출력 메서드
        {
            Console.WriteLine($"{name} : {price}원");
        }
    }
    private static void Main(string[] args)
    {
        Product productA = new Product() { name = "감자", price = 2000 };
        Product productB = new Product() { name = "고구마", price = 3000 };

        // 출력 메서드 호출하여 콘솔창에 출력하기
        productA.output();
        productB.output();
    }
}