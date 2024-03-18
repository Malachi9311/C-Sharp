namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            Animal dog = new Animal();

            dog.SetName("Max");
            dog.Sound = "woof";

            System.Console.WriteLine("The dog is named {0} and says {1}", dog.GetName(), dog.Sound);

            dog.Owner = "Malachi";
            System.Console.WriteLine("{0} owns {1}", dog.Owner, dog.GetName());

            System.Console.WriteLine("{0} has an id No. of: {1}", dog.GetName(), dog.idNum);

            System.Console.WriteLine("{0} is 1 of {1} Animals at {2}", dog.GetName(), Animal.NumOfAnimals, Animal.SHELTER);
        }
    }
}