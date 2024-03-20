namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior ironman = new Warrior("Ironman", 245, 23, 23);
            Warrior thor = new Warrior("Thor", 245, 31, 10);

            Battle.StartFight(ironman, thor);
        }
    }
}