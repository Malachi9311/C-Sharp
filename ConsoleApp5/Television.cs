namespace ConsoleApp5
{
    class Television : IElectronicDevice
    {
        public int Volume { get; set; }

        public void On()
        {
            System.Console.WriteLine("The TV is On");
        }

        public void Off()
        {
            System.Console.WriteLine("The TV is Off");
        }

        public void VolumeUp()
        {
            if (Volume != 100) Volume++;
            System.Console.WriteLine($"Volume is at {Volume}");
        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;
            System.Console.WriteLine($"Volume is at {Volume}");
        }
    }
}