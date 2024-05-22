internal class Program
{
    class Box
    {
        // 면적
        private int area;
        public void SetArea(int width, int heigt)
        {
            if (Width > 0 && heigt > 0)
            {
                this.area = this.width * this.height;
                Console.WriteLine($"면적 : {Width} * {Height} = {area}");
            }

            else
            {
                Console.WriteLine("면적을 구할 수 없음!");
            }

        }

        // 너비
        private int width;
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0) { width = value; }      // 값이 0보다 크면 값을 width에 넣음
                else { Console.WriteLine("너비는 자연수로 입력하세요."); }     // 너비를 음수로 입력했거나 0일 때
            }
        }

        // 높이
        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) { height = value; }
                else { Console.WriteLine("높이는 자연수로 입력하세요."); }
            }
        }

        // 생성자
        public Box(int width, int height)
        {
            // 너비 값을 속성에 넣음
            Width = width;
            Height = height;
        }

        // 인스턴스 메서드
        public int Area() { return width * height; }

    }
    private static void Main(string[] args)
    {
        // 너비 입력 받기
        Console.Write("너비를 입력하세요 : ");
        int width = int.Parse(Console.ReadLine());

        // 높이 입력 받기
        Console.Write("높이를 입력하세요 : ");
        int height = int.Parse(Console.ReadLine());

        Box box = new Box(width, height);
        box.SetArea(width, height);
    }
}