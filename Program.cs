// See https://aka.ms/new-console-template for more information
<<<<<<< HEAD
using System;

public interface IAnimal
{
    void Speak();
    void Move();
}

public class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Woof!");
    }

    public void Move()
    {
        Console.WriteLine("The dog runs.");
    }
}

public class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Meow!");
    }

    public void Move()
    {
        Console.WriteLine("The cat walks gracefully.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        IAnimal dog = new Dog();
        IAnimal cat = new Cat();

        dog.Speak();
        dog.Move();

        cat.Speak();
        cat.Move();
    }
}
=======
Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
Console.Write($"{Environment.NewLine}Press Enter to exit...");
Console.Read();
>>>>>>> 4fb18311540c30c3eab447ffe0f2a19dc3a2b16c
