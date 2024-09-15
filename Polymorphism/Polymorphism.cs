namespace Inlämningsuppgift.Polymorphism
{
    public class Animal // Huvudklassen för Animal
    {
        // Attribut för Animal, med inkapsling (getter/setter)
        public string Name;
        public int Age;

        // Virtuell metod som kan överskrivas i underklasser
        public virtual void Speak()
        {
            Console.WriteLine("This animal makes a sound.");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("This animal is sleeping.");
        }
    }

    // Underklass som använder polymorfism för att överskrida metoder
    public class Dog : Animal
    {
        public string Breed; 

        // Överskrider basklassens Speak-metod
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    public class Cat : Animal
    {
        public string Color;

        // Överskrider basklassens Speak-metod
        public override void Speak()
        {
            Console.WriteLine("The cat meows.");
        }
    }
}