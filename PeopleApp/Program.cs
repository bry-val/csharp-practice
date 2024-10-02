using Packt.Shared;

ConfigureConsole();

/// Practicing with OOP and generics

Person bob = new();

bob.Name = "Bob Smith";

bob.Born = new DateTimeOffset(
    year: 2000, month: 09, day: 26,
    hour: 16, minute: 28, second: 39,
    offset: TimeSpan.FromHours(-5));

bob.FavoriteWonder = WondersOfTheAncientWorld.GreatPyramidOfGiza;

bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

bob.Children.Add(new() { Name = "Alfred" });
bob.Children.Add(new() { Name = "Bella" });
bob.Children.Add(new() { Name = "Zoe" });

Console.WriteLine($"{bob.Name} has {bob.Children.Count} children");

foreach (Person p in bob.Children)
{
    Console.WriteLine($"> {p.Name}");
}

Console.WriteLine($"bobs list: {bob.BucketList}");

Console.WriteLine(bob.Birthday());
Console.WriteLine(bob.FavWonder());

Person alice = new()
{
    Name = "Alice Jones",
    Born = new(2201, 03, 07, 12, 29, 0, TimeSpan.Zero)
};

// Console.WriteLine(alice.Birthday());

Console.WriteLine(Person.Species);

/// Static members practice

BankAccount.InterestRate = 0.012M;

BankAccount jonesAccount = new()
{
    AccountName = "Mrs. Jones",
    Balance = 2400
};

BankAccount gerrierAccount = new()
{
    AccountName = "Ms. Gerrier",
    Balance = 98
};

Console.WriteLine($"{jonesAccount.AccountName} earned {(jonesAccount.Balance * BankAccount.InterestRate):C} interest.");
Console.WriteLine($"{gerrierAccount.AccountName} earned {(gerrierAccount.Balance * BankAccount.InterestRate):C} interest.");

