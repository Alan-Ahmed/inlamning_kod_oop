namespace Inlämningsuppgift.inkapsling
{
    public class Car
    {
        public string Brand;
        private int year; // Privat fält för att lagra värdet av Year

        public int Year
        {
            get { return year; }
            set
            {
                if (value > 1885)
                {
                    year = value; // Tilldela till det privata fältet
                }
            }
        }

        public void StartEngine() => Console.WriteLine($"{Brand} from {Year} starts its engine.");
        public void Drive() => Console.WriteLine($"{Brand} is now driving.");
    }
}
