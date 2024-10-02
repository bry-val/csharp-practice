
// -- Try catch and handling exceptions --

Console.WriteLine("Before parsing");
Console.Write("What is your age? ");
string? input = Console.ReadLine();

try
{
    int age = int.Parse(input!);
    Console.WriteLine($"You are {age} years old.");
}
catch (FormatException)
{
    Console.WriteLine($"Invalid age value.");
}
catch (OverflowException)
{
    Console.WriteLine($"Age number too large.");
}
catch (Exception e)
{
    Console.WriteLine($"{e.GetType()} says {e.Message}");
}
Console.WriteLine("after parse");

// -- try catch when loop --

Console.Write("Enter an amount!: ");

string amount = Console.ReadLine()!;

if (string.IsNullOrEmpty(amount)) return;

try 
{
    decimal amountValue = decimal.Parse(amount);
    Console.WriteLine($"Amount as currency: {amountValue:C}");
}
catch (FormatException) when (amount.Contains("$"))
{
    Console.WriteLine("Amounts cannot use dollar sign!");
}
catch (FormatException)
{
    Console.WriteLine("Improper format for currency!");
}

// -- Overflow handling -- 

try
{
    checked
    {
        int x = int.MaxValue - 1;

        Console.WriteLine($"Initial val: {x}");
        x++;
        Console.WriteLine($"Single Increment: {x}");
        x++;
        Console.WriteLine($"Second Increment: {x}");
        x++;
        Console.WriteLine($"Third Increment: {x}");
    }
}
catch (OverflowException)
{
    Console.WriteLine("Overflowed code! Exception caught");
}

unchecked
{
    int y = int.MaxValue + 1;
    Console.WriteLine($"Initial val: {y}");
    y--;
    Console.WriteLine($"First decr: {y}");
    y--;
    Console.WriteLine($"Second decr: {y}");
}
