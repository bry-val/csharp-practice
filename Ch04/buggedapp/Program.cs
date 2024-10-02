// using static System.Console;

// Write("Enter a number: ");
// double num = double.Parse(ReadLine()!);

// double a = 4.5;
// double b = 2.5;

// double answer = Add(a, b);

// WriteLine($"{a} + {b} = {answer}");
// WriteLine("Press enter...");
// ReadLine();
// WriteLine("Done executing");

// // deliberate bug for debugging practice
// double Add(double a, double b)
// {
//     return a + b; 
// }

static void Withdraw(string accountName, decimal amount)
{
    ArgumentException.ThrowIfNullOrWhiteSpace(accountName);
    ArgumentOutOfRangeException.ThrowIfNegativeOrZero(amount);

    Console.WriteLine($"Withdrew {amount} from {accountName}");
}

Withdraw(accountName: "BTUS", amount: -1500);