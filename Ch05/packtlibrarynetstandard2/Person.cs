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

    #endregion

    public string Birthday()
    {
        return $"{this.Name} was born on {this.Born}";
    }
    public string FavWonder()
    {
        return $"{this.Name}'s favorite wonder is {this.FavoriteWonder}. Its integer is {(int)this.FavoriteWonder}";
    }
}

