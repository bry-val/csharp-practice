using System.Globalization;
using System.Security.Cryptography;

/// <summary>
///  Partial Class Implementation to keep main function clean... This also allows these static functions to be at the same level as Main versus always being constrained locally.
///  This allows XML documentation for our static functions. 
/// </summary>
partial class Program
{
    static void TimesTable(byte number, byte size = 12)
    {
        Console.WriteLine($"This is the {number} times table with {size} rows:");
        Console.WriteLine();

        for (int row = 1; row <= size; row++)
        {
            Console.WriteLine($"{row} * {number} = {row * number}");
        }
        Console.WriteLine();
    }

    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        twoLetterRegionCode = twoLetterRegionCode.ToUpper();
        
        decimal rate = twoLetterRegionCode switch
        {
            "CH" => 0.08M,
            "DK" or "NO" => 0.25M,
            "GB" or "FR" => 0.2M,
            "HU" => 0.27M,
            "OR" or "AK" or "MT" => 0.0M,
            "ND" or "WI" or "ME" or "VA" => 0.05M,
            "CA" => 0.0825M,
            _ => 0.06M
        };

        return amount * rate;
    }

    static void ConfigureConsole(string culture = "en-US", bool useComputerCulture = false)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }
        Console.WriteLine($"CurrentCulture: {CultureInfo.CurrentCulture.DisplayName}");
    }
/// <summary>
/// Pass a 32-bit unsigned integer and it will be converted into an equivalent ordinal string. 
/// </summary>
/// <param name="number">Cardinal number. (Counting numbers)</param>
/// <returns>Cardinal number converted to a string representation of that number as ordinal. (Positional)</returns>
    static string CardinalToOrdinal(uint number)
    {
        uint lastTwoDigits = number % 100;

        switch (lastTwoDigits)
        {
            case 11:
            case 12:
            case 13:
                return $"{number:N0}th";
            default:
                uint lastDigit = number % 10;

                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };

                return $"{number:N0}{suffix}";
        }
    }
///
    static int Factorial(int number)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(number);

        if (number == 0)
        {
            return 1;
        }
        checked
        {
            return number * Factorial(number - 1);
        }
    }

    static int FibImperative(uint term)
    {
        ArgumentOutOfRangeException.ThrowIfZero(term);

        if (term == 1)
        {
            return 0;
        }
        else if (term == 2)
        {
            return 1;
        }

        return FibImperative(term - 1) + FibImperative(term - 2);
    }

    static int FibFunctional(uint term) => term switch
    {
        0 => throw new ArgumentOutOfRangeException(paramName: nameof(term)),
        1 => 0,
        2 => 1,
        _ => FibFunctional(term - 1) + FibFunctional(term - 2)
    };
}