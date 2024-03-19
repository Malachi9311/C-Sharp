namespace ConsoleApp3
{
    class Dog : Animal
    {
        // Additional Properties.
        public string Sound2 { get; set; } = "Grrrr";

        public override void MakeSound()
        {
            System.Console.WriteLine($"{Name} say {Sound} and {Sound2}.");
        }
    }
}