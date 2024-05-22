// 클래스 생성
class Car
{
    // 속성 정의
    int carNum;                 // 차량 번호
    public DateTime inTime;    // 입차 시간
    public DateTime outTime;   // 출차 시간
    // public --> 공공의 라는 뜻으로, 모든 곳에 접근 가능하게 함

    public void SetInTime()     // 입차 시간 메서드
    {
        this.inTime = DateTime.Now;
    }
    public void SetOutTime()    // 출차 시간 메서드
    {
        this.outTime = DateTime.Now;
    }
}   // Car 클래스는 메서드가 2개이며, 메서드는 반환값이 없음
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