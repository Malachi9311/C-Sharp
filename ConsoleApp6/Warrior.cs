namespace ConsoleApp6
{
    class Warrior
    {
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        public Warrior(string name = "Warrior", double health = 0, double attMax = 0, double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttMax = attMax;
            BlockMax = blockMax;
        }

        Random rnd = new Random();

        public double Attack()
        {
            return rnd.Next(1, (int)AttMax);
        }

        public virtual double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }

    }
}