namespace Inlämningsuppgift.Arv
{
    internal class programarv
    {
        static void Main(string[] args)
        {
            Robot robot1 = new Robot();
            robot1.Battery();

            Robot robot2 = new Robot();
            robot2.Charge();

            Robcat robcat = new Robcat();
            robcat.Charge();
        }
    }
}
