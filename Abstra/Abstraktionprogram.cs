using Inlämningsuppgift.Abstraction;
    public class Program
    {
        static void Main(string[] args)
        {
            // Skapar en instans av Dog som ärver från abstrakta klassen Animal
            Animal myDog = new Dog();

            // Anropar metoder från abstrakt klass 
            myDog.Speak(); 
            myDog.Sleep();

            Animal myCat = new Cat();
            myCat.Speak();
            myCat.Sleep();

            Console.ReadLine();
        }
    }

