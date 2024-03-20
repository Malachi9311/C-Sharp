namespace ConsoleApp5
{
    // Interface only contains Abstract methods.
    // All the classes that inherit from an interface
    // must have the declared properties and methods.

    interface IDrivable
    {
        int Wheels { get; set; }
        double Speed { get; set; }

        void Move();
        void Stop();
    }
}