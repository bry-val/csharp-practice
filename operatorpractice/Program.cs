int x = 3;
int y = 2 + ++x;

Console.WriteLine($"Guess: 6, Actual {y}");

int z = 3 << 2;
// 00000011
// 1100
Console.WriteLine($"Guess: 12, Actual {z}");

int tg = 10 >> 1;
Console.WriteLine($"Guess: 5, Actual {tg}");


int q = 10 & 8;
// 1010
// 1000
// 1000
Console.WriteLine($"10: {10:B}, 8: {8:B}");
Console.WriteLine($"Guess: 1, Actual {q}");


int rt = 10 | 7;
// 0111
// 1010
// 1111
Console.WriteLine($"Guess: 15, Actual {rt}");

