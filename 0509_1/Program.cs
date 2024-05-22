using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


/* 속성은 private가 아니라 public 
속성은 항상 규칙이있다. 
대문자로 쓴다. 
코드를 다 속성으로 고쳐서 다시 쓰시오 사진 문제임 red*/





using System;
using System.Collections.Generic;

class Animal
{
    public int Age { get; set; }

    public Animal()
    {
        Age = 1;
    }

    public void Eat()
    {
        Console.WriteLine("냠냠 먹습니다.");
    }

    public void Sleep()
    {
        Console.WriteLine("쿨쿨 잠을 잡니다.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("멍멍 짖습니다.");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("야옹 소리를 냅니다.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();

        Dog dog = new Dog();
        Cat cat = new Cat();

        animals.Add(dog);
        animals.Add(cat);

        foreach (var animal in animals)
        {
            animal.Eat();
            animal.Sleep();

           //as 로 바꿔보기 

            if (animal is Dog)
            {
                ((Dog)animal).Bark();
            }
            else if (animal is Cat)
            {
                ((Cat)animal).Meow();
            }
        }
    }
}
