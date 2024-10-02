// TimesTable(13, 43);
// TimesTable(7);

// ConfigureConsole();

// decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "fr");

// Console.WriteLine($"You must pay {taxToPay:C} in tax.");

// static void RunCardinalToOrdinal()
// {
//     for (uint i = 1; i <= 150; i ++)
//     {
//         Console.Write($"{CardinalToOrdinal(number: i)}\t");
//     }
//     Console.WriteLine();
// }

// static void RunFactorial(int limit)
// {
//     for (int i = -2; i <= limit; i ++)
//     {
//         try 
//         {
//             int result = Factorial(i);
//             Console.WriteLine($"{i}! = {result:N0}");
//         }
//         catch (Exception e)
//         {
//             Console.WriteLine($"{i}!: {e.Message}");
//         }

//     }
// }

static void RunFibImperative()
{
    for (uint i = 1; i <= 30; i++)
    {
        Console.WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci sequence is {FibImperative(i):N0}");
    }
}


static void RunFibFunctional()
{
    for (uint i = 1; i <= 30; i++)
    {
        Console.WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci sequence is {FibFunctional(i):N0}");
    }
}



// RunCardinalToOrdinal();

// RunFactorial(limit: 13);

RunFibFunctional();