namespace Inlämningsuppgift.Abstraction;

// Abstrakt basklass
public abstract class Animal
{
    // Abstrakta metoder som måste implementeras av underklasser
    public abstract void Speak();
    public abstract void Sleep();
}

// Underklass som implementerar den abstrakta basklassen
public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }

    public override void Sleep()
    {
        Console.WriteLine("The dog is sleeping.");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The cat meows.");
    }

    public override void Sleep()
    {
        Console.WriteLine("The cat is sleeping.");
    }
}