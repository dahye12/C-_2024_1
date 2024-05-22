﻿using System;
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

        List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
        List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };
        Animal Animals = new List<Animal>() { new Dog(),new Dog(),new Dog(),new Dog() };

        foreach (var item in Dogs)
        {
            item.Eat();
            item.Sleep();
            item.Bark();

            if(item is Dog = )
        }

        foreach (var item in Cats)
        {
            item.Eat();
            item.Sleep();
            item.Meow();
        }
    }
}
