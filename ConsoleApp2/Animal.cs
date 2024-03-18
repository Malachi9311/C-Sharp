namespace ConsoleApp2
{
    class Animal
    {
        private string name;
        private string sound;
        public const string SHELTER = "Malachi's Home For animals";
        public readonly int idNum;

        // Default constructor
        // "this" keyword passed on to the next constructor
        public Animal()
            : this("No Name", "No Sound") { }

        // If the name is passed into params
        // "this" keyword passed on to the next constructor
        public Animal(string name)
            : this(name, "No Sound") { }

        // If both name and sound param are passed
        // No "this" keyword to pass on to another constructor
        public Animal(string name, string sound)
        {
            SetName(name);
            Sound = sound;
            NumOfAnimals = 1;
            Random rnd = new Random();
            idNum = rnd.Next(1, int.MaxValue);

        }

        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No name";
                System.Console.WriteLine("Name can't contain digits in it!");
            }
        }

        public string GetName()
        {
            return this.name;
        }

        // Getter and Setter methods
        // no params in function
        // "value" variable implicit
        public string Sound
        {
            get
            {
                return this.sound;
            }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    System.Console.WriteLine("Sound is too long");
                }
                else
                {
                    this.sound = value;
                }
            }
        }

        // Auto generate Getters and Setters with a default value.
        public string Owner { get; set; } = "No Owner";

        public static int numOfAnimals = 0;

        public static int NumOfAnimals
        {
            get
            {
                return numOfAnimals;
            }
            set
            {
                numOfAnimals += value;
            }
        }
    }
}