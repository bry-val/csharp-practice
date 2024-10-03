namespace Packt.Shared;

public class Person : object
{
    #region Fields: Data or state for this person.

    public string? Name;
    public DateTimeOffset Born;
    public WondersOfTheAncientWorld FavoriteWonder;
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
        return $"{this.Name}'s favorite wonder is {this.FavoriteWonder}. Its integer is {(int)this.FavoriteWonder}";
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

    //Tuple practice
    public (string Name, int Dollar) GetFruit()
    {
        return (Name: "Apples", Dollar: 20);
    }

    #endregion
}

