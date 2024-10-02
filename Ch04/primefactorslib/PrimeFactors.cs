
using System.Text;

namespace primefactorslib;

public class PrimeFactors
{
    
    public static string PrimeFactorization(int num)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(num);
        StringBuilder sb = new();
        string separator = " * ";
        bool isFirstFactor = true;

        while (num % 2 == 0)
        {
            if (!isFirstFactor)
            {
                sb.Append(separator);
            }
            sb.Append('2');
            num /= 2;
            isFirstFactor = false;
        }

        int factor = 3;
        while (factor * factor <= num)
        {
            while (num % factor == 0)
            {
                if (!isFirstFactor)
                {
                    sb.Append(separator);
                }
                sb.Append(factor);
                num /= factor;
                isFirstFactor = false;
            }
            factor += 2;
        }

        if (num > 2)
        {
            if (!isFirstFactor)
            {
                sb.Append(separator);
            }
            sb.Append(num);
        }

        return sb.ToString();
    }
}
