namespace ConsoleApp5
{
    class Vehicle : IDrivable
    {
        public string Brand { get; set; } = "";
        public int Wheels { get; set; }

        public double Speed { get; set; }

        public Vehicle(string brand = "No brand", int wheels = 0, double speed = 0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }



        public void Move()
        {
            System.Console.WriteLine($"The {Brand} moves at {Speed} MPH");
        }

        public void Stop()
        {
            System.Console.WriteLine($"The {Brand} stopped");
            Speed = 0;
        }

    }
}