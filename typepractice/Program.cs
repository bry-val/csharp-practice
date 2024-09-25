// double urMom = Math.Round(-12.5, 0, MidpointRounding.ToEven);
// Console.WriteLine(urMom);
// int a = 10;
// double b = a;
// Console.WriteLine($"a is {a}. b is {b}");

// double c = 9.8;
// int d = (int)c;

// Console.WriteLine($"c is {c}, d is {d}");

// using static System.Convert;

// double g = 9.8;
// int h = ToInt32(g);

// Console.WriteLine(h);

// -- Base64 encoding --

// byte[] binaryObject = new byte[128];

// Random.Shared.NextBytes(binaryObject);

// Console.WriteLine("Binary object as bytes:");
// for (int index = 0; index < binaryObject.Length; index ++)
// {
//     Console.Write($"{binaryObject[index]:X2}");
// }
// Console.WriteLine();

// string encoded = ToBase64String(binaryObject);
// Console.WriteLine($"Binary Object as Base64: {encoded}");


// using System.Globalization;

// CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

// int friends = int.Parse("27");
// DateTime birthday = DateTime.Parse("4 June 1980");
// Console.WriteLine($"I have {friends} to invite to my party");
// Console.WriteLine($"My birthday is {birthday}");
// Console.WriteLine($"My birthday is {birthday:D}");

// Console.Write("How many eggs are there? ");
// string? input = Console.ReadLine();

// if (int.TryParse(input, out int count))
// {
//     Console.WriteLine($"There are {count} eggs!");
// }
// else
// {
//     Console.WriteLine("I could not parse the input");
// }

