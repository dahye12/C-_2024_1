using _0411_01;         // 외부 클래스를 포함하기 위해 솔루션 이름으로 적어주기

// Main --> 꼭 있어야 하는 클래스 !!
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