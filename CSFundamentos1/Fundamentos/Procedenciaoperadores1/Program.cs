Console.WriteLine("## Procedência de operadores ##\n");

int x = 10 - 2 * 3;
Console.WriteLine(x);

int y = (10 - 2) * 3;
Console.WriteLine(y);

bool b = !(9 != 8) && 5 >= 7 || 8 >= 6;
Console.WriteLine(b);

bool c = !(9 != 8) && (5 >= 7 || 8 >= 6);
Console.WriteLine(c);

int m = 5, n = 6, o = 4;
int r = --m * n - ++o;
Console.WriteLine(r);

Console.ReadKey();