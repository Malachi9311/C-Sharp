namespace ConsoleApp6
{
    class MagicWarrior : Warrior
    {
        int teleportChance = 0;

        CanTelePort teleportType = new CanTelePort();

        public MagicWarrior(string name = "Warrior", double health = 0, double attMax = 0, double blockMax = 0, int teleportChance = 0)
            : base(name, health, attMax, blockMax)
        {
            this.teleportChance = teleportChance;
        }

        public override double Block()
        {
            Random rnd = new Random();
            int rndDodge = rnd.Next(1, 100);

            if (rndDodge < this.teleportChance)
            {
                System.Console.WriteLine($"{Name} {teleportType.teleport()}");
                return 10000;
            }
            else
            {
                return base.Block();
            }
        }
    }
}