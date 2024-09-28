using primefactorslib;

string four = PrimeFactors.PrimeFactorization(4);
string seven = PrimeFactors.PrimeFactorization(7);
string thirty = PrimeFactors.PrimeFactorization(30);
string forty = PrimeFactors.PrimeFactorization(40);
string fifty = PrimeFactors.PrimeFactorization(50);
string twothoushandthreehundred = PrimeFactors.PrimeFactorization(2300);

Console.WriteLine($"4: {four}");
Console.WriteLine($"7: {seven}");
Console.WriteLine($"30: {thirty}");
Console.WriteLine($"40: {forty}");
Console.WriteLine($"50: {fifty}");
Console.WriteLine($"2300: {twothoushandthreehundred}");
