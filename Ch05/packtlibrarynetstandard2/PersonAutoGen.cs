namespace Packt.Shared;

public partial class Person
{
    public string? FavoriteIceCream { get; set; }
    private WondersOfTheAncientWorld _favoriteWorldWonder;
    public WondersOfTheAncientWorld FavoriteWorldWonder
    {
        get
        {
            return _favoriteWorldWonder;
        }
        set
        {
            string wonderName = value.ToString();

            if (wonderName.Contains(','))
            {
                throw new ArgumentException();
            }

            if (!Enum.IsDefined(typeof(WondersOfTheAncientWorld), value))
            {
                throw new ArgumentException();
            }

            _favoriteWorldWonder = value;
        }
    }
    private string? _favoritePrimaryColor;

    public string? FavoritePrimaryColor
    {
        get
        {
            return _favoritePrimaryColor;
        }
        set
        {
            _favoritePrimaryColor = (value?.ToLower()) switch
            {
                "red" or "blue" or "green" => value,
                _ => throw new ArgumentException(),
            };
        }
    }

    #region Properties: Methods to get or set data or state

    //read-only
    public string Origin
    {
        get
        {
            return $"{Name} was born on {HomePlanet}";
        }
    }

    //readonly using lambdas

    public string Greeting => $"{Name} says Hello!";
    public int Age => DateTime.Today.Year - Born.Year;

    #endregion

    #region Indexers: Properties that use the array syntax to access them!

    public Person this[int index]
    {
        get
        {
            return Children[index];
        }
        set
        {
            Children[index] = value;
        }
    }

    public Person this[string name]
    {
        get
        {
            return Children.Find(p => p.Name == name);
        }
    }

    #endregion
}