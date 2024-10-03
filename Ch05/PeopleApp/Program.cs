using Packt.Shared;

//named Tuple
using Fruit = (string Name, int Number);

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

// Book book = new()
// {
//     Isbn = "952-5259366655",
//     Title = "C# 12"
// };

// Console.WriteLine($"{book.Title} written by {book.Author}");

// initializing fields with constructors
Person blankP = new();
Person blankQ = new(initialName: "Arthur", "Gazebo");

Console.WriteLine($"{blankP.Name} of Planet {blankP.HomePlanet} created on {blankP.Instantiated:D}");
Console.WriteLine($"{blankQ.Name} of Planet {blankQ.HomePlanet} created on {blankQ.Instantiated:D}");

// init with constructor
Book book = new(isbn: "978-9874165", title: "Witcher 3") 
{ 
    Author = "Bryan B", 
    PageCount = 45 
};

bool isFat;

bob.WriteToConsole();
Console.WriteLine(bob.GetOrigin());
Console.WriteLine(bob.GetOrigin(height: 12, great: true, fat: out isFat));

Console.WriteLine($"Is Bob fat? {isFat}");
Console.WriteLine(bob.GetOrigin(height: 12, great: false, fat: out isFat));
Console.WriteLine($"Is Bob fat? {isFat}");


(string fruitName, int fruitAmount) = bob.GetFruit();
var fruitTuple= bob.GetFruit();
Fruit fruple = bob.GetFruit();
Console.WriteLine($"{fruitName} cost {fruitAmount:C}");
Console.WriteLine($"{fruitTuple.Name} cost {fruitTuple.Dollar:C}");

Fruit apple = ("Apple", 12);

Console.WriteLine(format: "{0}, {1}", apple.Name, apple.Number);