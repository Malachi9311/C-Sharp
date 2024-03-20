namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle toyota = new Vehicle("Toyota 86", 4, 210);

            toyota.Move();
            toyota.Stop();

            bool isInstance = toyota is IDrivable;
            System.Console.WriteLine($"{isInstance}");

            System.Console.WriteLine("-------------");

            IElectronicDevice tv = TVRemote.GetDevice();
            System.Console.WriteLine(tv.GetType());
            PowerButton powerButton = new PowerButton(tv);

            powerButton.Execute();
            powerButton.Undo();
            powerButton.Execute();
            powerButton.Undo();

        }
    }
}