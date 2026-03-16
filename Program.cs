// See https://aka.ms/new-console-template for more information
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