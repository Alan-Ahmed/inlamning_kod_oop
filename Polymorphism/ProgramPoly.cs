namespace Inlämningsuppgift.Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.Speak();

            Animal myDog = new Dog(); // Polymorfism
            myDog.Speak(); // Anropar Dog-versionen av Speak()

            Animal myCat = new Cat(); // Polymorfism
            myCat.Speak(); // Anropar Cat-versionen av Speak()

            Console.ReadLine();
        }
    }

}