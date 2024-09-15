namespace Inlämningsuppgift.Arv
{
    public class Robot // Huvudklassen för Robot
    { // Attrebuter av klassen robot 
        public string Namn;

        public int Age;

        public void Charge()  // Metod
        {
            Console.WriteLine("This robot it can charge itself");
        }

        public void Battery() // Metod
        {
            Console.WriteLine("This robot is running on battery");
        }
    }

    public class Robcat : Robot // Nya attrebuter + Alla andra attrebuter av huvudklassen
    {
        public int Newdesign;

        public new void Charge() // Ny metod 
        {

            Console.WriteLine("This robot is half cat it recharges when it sleeps!");

        }
    }

}