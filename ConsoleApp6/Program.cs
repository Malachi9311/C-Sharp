namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior ironman = new Warrior("Ironman", 100, 23, 23);
            MagicWarrior thor = new MagicWarrior("Thor", 100, 31, 10, 10);

            Battle.StartFight(ironman, thor);
        }
    }
}