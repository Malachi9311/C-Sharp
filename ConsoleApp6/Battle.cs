namespace ConsoleApp6
{
    class Battle
    {
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {

            }
        }

        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warAAttAmt = warriorA.Attack();
            double warBBlkAmt = warriorB.Block();

            double dmg2warB = warAAttAmt - warBBlkAmt;

            if (dmg2warB > 0)
            {
                warriorB.Health -= dmg2warB;
            }
            else
            {
                dmg2warB = 0;
            }

            System.Console.WriteLine($"{warriorA.Name} attacks {warriorB.Name} and deals {dmg2warB} damage");
            System.Console.WriteLine($"{warriorB.Name} has {warriorB.Health}");

            if (warriorB.Health <= 0)
            {
                System.Console.WriteLine($"{warriorB.Name} has died and {warriorA.Name} is the Victor\n");
                return "Game Over";
            }
            return "Fight Again";
        }
    }
}