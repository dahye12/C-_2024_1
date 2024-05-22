using ConsoleApp6;
internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car();    // 클래스를 변수로 선언함 --> 인스턴스 생성, 인스턴스 명은 car
        // 클래스 Car의 이름을 main 에서는 car로 만듦.
        car.SetInTime();
        car.SetOutTime();

        // 출력하기
        Console.WriteLine("입차 시간 : " + car.inTime);
        Console.WriteLine("출차 시간 : " + car.outTime);
        Console.WriteLine();
        Console.WriteLine($"입차 시간 : {car.inTime}\n출차 시간 : {car.outTime}");

    }
}