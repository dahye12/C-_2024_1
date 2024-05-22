internal class Program
{
    class Product
    {
        public static int counter = 0;
        private string id;
        private string name;
        private int price;

        public Product(string name, int price)
        {
            this.id = $"{++counter}"; // 각 제품의 고유한 ID 생성
            this.name = name;
            this.price = price;
        }

        public string getId() { return id; }

        public string getName() { return name; }

        public int getPrice() { return price; }
    }
    private static void Main(string[] args)
    {
        Product productA = new Product("감자", 2000);
        Product productB = new Product("고구마", 3000);

        Console.WriteLine(productA.getId() + " " + productA.getName() + " : " + productA.getPrice());
        Console.WriteLine(productB.getId() + " " + productB.getName() + " : " + productB.getPrice());
        Console.WriteLine($"{productB.getId()}개 생성되었습니다.");
    }
}
;
