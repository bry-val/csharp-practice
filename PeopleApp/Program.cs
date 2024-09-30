using Packt.Shared;

ConfigureConsole();

Person bob = new();

bob.Name = "Bob Smith";

bob.Born = new DateTimeOffset(
    year: 2000, month: 09, day: 26,
    hour: 16, minute: 28, second: 39,
    offset: TimeSpan.FromHours(-5));

Console.WriteLine(bob.Birthday());

Person alice = new()
{
    Name = "Alice Jones",
    Born = new(2201, 03, 07, 12, 29, 0, TimeSpan.Zero)
};

Console.WriteLine(alice.Birthday());

