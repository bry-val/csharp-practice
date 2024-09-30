namespace Packt.Shared;

public class Person : object
{
    #region Fields: Data or state for this person.

    public string? Name;
    public DateTimeOffset Born;

    #endregion

    public string Birthday()
    {
        return $"{this.Name} was born on {this.Born}";
    }
}

