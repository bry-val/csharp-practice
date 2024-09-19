// Array Practice

// -- Single Dim. Array Practice --
// string[] names = new string[4];

// names[0] = "Kate";
// names[1] = "Jeff";
// names[2] = "Goldblum";
// names[3] = "Heidoi";

// string[] names2 = { "Kate", "Jeff", "Goldblum", "Heidi" };

// for (int i = 0; i < names2.Length; i ++)
// {
//     Console.WriteLine($"{names2[i]} is at position {i}");
// }

// Multi-dim array with fixed sized 
// NOTE: when declaring arrays like this, each nested array is expected to be the same size as the first initializer
// if a value needs to be missing, ensure either the array is made of nullable strings or string.Empty is used. 

// string[,] grid1 =
// {
//     {"Alpha", "Neta", "Hama", "OKLappa"},
//     {"Ben", "Dover", "Flerp", "Lip"},
//     {"Smacka", "Shlappa", "Cat", "Barda"}
// };

// for (int row = 0; row <= grid1.GetUpperBound(0); row++)
// {
//     for (int col = 0; col <= grid1.GetUpperBound(1); col++)
//     {
//         Console.WriteLine($"Row {row}, Col {col}: {grid1[row, col]}");
//     }
// }

// array without init syntax. empty string are automatic?

// string[,] grid2 = new string[3,4];

// grid2[0, 0] = "Janky";
// grid2[2, 2] = "hanky";
// grid2[1, 1] = "ganky";
// grid2[2, 3] = "aanky";
// grid2[0, 1] = "Panky";

// for (int row = 0; row <= grid2.GetUpperBound(0); row++)
// {
//     for (int col = 0; col <= grid2.GetUpperBound(1); col++)
//     {
//         Console.WriteLine($"Row {row}, Col {col}: {grid2[row, col]}");
//     }
// }

// -- Jagged arrays --
// Jagged arrays are arrays of arrays where inner arrays are not uniform size. 
// These can be traversed by dynamically getting the upper bound of each inner array in a loop == to the size of outer array

// string[][] jagged =
// {
//     new[] { "alpga", "sdfkbsd", "ajkfas"},
//     new[] { "dfgdfgdf", "dfgdfgdfg", "svdsfv", "ghdsbhkj"},
//     new[] { "451dfv", "rewfv"}
// };

// Console.WriteLine($"Upper bound of the array or arrays {jagged.GetUpperBound(0)}");

// for (int array = 0; array <= jagged.GetUpperBound(0); array++)
// {
//     Console.WriteLine($"Upper bound of array {array} is: {jagged[array].GetUpperBound(0)}");
// }

// for (int row = 0; row <= jagged.GetUpperBound(0); row++)
// {
//     for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
//     {
//         Console.WriteLine($"Row: {row} Col: {col} {jagged[row][col]}");
//     }
// }

// -- List Pattern Matching --

// int[] oneOneAny = { 1, 1, 21 };
// int[] emptySet = {};
// int[] oneTwoThree = { 1, 2, 3 };
// int[] oneTwoTen = { 1, 2, 10 };
// int[] fourItem = { 34, 53, 2, 123 };
// int[] randomNum = { 34, 53, 2, 123, 468};
// int[] primeNum = { 2, 34, 7, 9 };

// static string CheckSwitch(int[] values) => values switch
// {
//     [] => "Empty!",
//     [1, 2, 3] => "one two three",
//     [1, _, 3] => "One, any, three",
//     [1, 2, _] => "One two followed by any",
//     [1, ..] => "One followed by many",
//     [2, .., 9] => "List of Primes",
//     [int item1, int item2, _, _] => $"Four item list starting with {item1} and {item2}",
//     _ => "Random"
// };

// Console.WriteLine($"{nameof(oneOneAny)}: {CheckSwitch(oneOneAny)}");
// Console.WriteLine($"{nameof(emptySet)}: {CheckSwitch(emptySet)}");
// Console.WriteLine($"{nameof(oneTwoThree)}: {CheckSwitch(oneTwoThree)}");
// Console.WriteLine($"{nameof(oneTwoTen)}: {CheckSwitch(oneTwoTen)}");
// Console.WriteLine($"{nameof(randomNum)}: {CheckSwitch(randomNum)}");
// Console.WriteLine($"{nameof(fourItem)}: {CheckSwitch(fourItem)}");
// Console.WriteLine($"{nameof(primeNum)}: {CheckSwitch(primeNum)}");

