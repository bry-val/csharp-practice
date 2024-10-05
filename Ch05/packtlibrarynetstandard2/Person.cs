namespace Packt.Shared;

public partial class Person : object
{
    #region Fields: Data or state for this person.

    public string? Name;
    public DateTimeOffset Born;
    //moved to PersonAutoGen.cs
    // public WondersOfTheAncientWorld FavoriteWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = [];
    public const string Species = "Homo Sapien";
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;

    #endregion

    #region Constructors: Called when using new.

    public Person()
    {
        //Default values can be set in constructors
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }
    
    public Person(string initialName, string homePlanet)
    {
        //Default values can be set in constructors
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }
    
    #endregion

    #region Methods

    public string Birthday()
    {
        return $"{this.Name} was born on {this.Born}";
    }
    public string FavWonder()
    {
        return $"{Name}'s favorite wonder is {FavoriteWorldWonder}. Its integer is {(int)FavoriteWorldWonder}";
    }

    public void WriteToConsole()
    {
        Console.WriteLine("This is a Person object.");    
    }

    public string GetOrigin()
    {
        return $"Returns an origin string. Let's say\n This person is located at (0,0)";
    }

    public string GetOrigin(bool great, out bool fat, string name = "Geronimo", int height = 72)
    {
        fat = true && great;
        return $"His name was {name}, he was {height} inches tall. Was he great? {great}";
    }

    //Method with a local function
    public static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        return localFactorial(number);

        int localFactorial(int localNumber)
        {
            if (localNumber == 0) return 1;
            return localNumber * localFactorial(localNumber - 1);
        }
    }

    //Tuple practice
    public (string Name, int Dollar) GetFruit()
    {
        return (Name: "Apples", Dollar: 20);
    }

    //Deconstructor practice
    public void Deconstruct(out string? name, out DateTimeOffset dob)
    {
        name = Name;
        dob = Born;
    }

    public void Deconstruct(out string? name, out DateTimeOffset dob, out WondersOfTheAncientWorld favorite)
    {
        name = Name;
        dob = Born;
        favorite = FavoriteWorldWonder;
    }

    #endregion
    
}

