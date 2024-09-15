using Inlämningsuppgift.inkapsling;

public class bil
{
    static void Main(string[] args)
    {   // Skapar en instans av Car-klassen och tilldelar värden till Brand och Year
        Car myCar = new Car { Brand = "Tesla", Year = 2023 };

        // Skriver ut bilens märke och årsmodell
        Console.WriteLine($"Bilmärket är {myCar.Brand} och årsmodellen är {myCar.Year}.");
        
        // Anropar metoden för att starta bilens motor
        myCar.StartEngine();

        // Anropar metoden för att köra bilen
        myCar.Drive();

        Console.ReadLine();
    }
}
