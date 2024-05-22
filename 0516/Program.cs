using System;

// 추상 클래스 Shape 정의
abstract class Shape
{
    // 추상 메소드 calculateArea
    public abstract double CalculateArea();

    // 비추상 메소드 Display
    public void Display()
    {
        Console.Write("This is shape ");
    }
}

// Circle 클래스 정의
class Circle : Shape
{
    private double radius;

    // 생성자
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // calculateArea 메소드 구현
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

// Rectangle 클래스 정의
class Rectangle : Shape
{
    private double width;
    private double height;

    // 생성자
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // calculateArea 메소드 구현
    public override double CalculateArea()
    {
        return width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 사각형의 가로와 세로를 입력 받음
        Console.WriteLine("Enter the width of the rectangle:");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the rectangle:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Circle 객체 생성 및 출력
        Circle circle = new Circle(5);
        circle.Display();
        Console.WriteLine("Circle Area: " + circle.CalculateArea().ToString("F2"));

        // Rectangle 객체 생성 및 출력
        Rectangle rectangle = new Rectangle(width, height);
        rectangle.Display();
        Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea().ToString("F2"));
    }
}