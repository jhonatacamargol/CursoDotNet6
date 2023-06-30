Console.WriteLine("## Nullable Types ##\n");

Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;

int? i1 = null;
double? d1 = null;
bool? b1 = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);

Console.WriteLine(i1);
Console.WriteLine(d1);
Console.WriteLine(b1);

int? a = 1;
int b2 = a ?? 0;

Console.WriteLine(b2);

int? x = 4;
int? y = 3;
int? z = x * y;

Console.WriteLine(z);

int? m = 100;
if (m.HasValue)
{
    Console.WriteLine($"b = {m.Value}");
}
else { Console.WriteLine("m não possui um valor (null)");
}

int? n = null;
if (n.HasValue)
{
    Console.WriteLine($"n = {n.Value}");
}
else
{
    Console.WriteLine("n não possui um valor (null)");
}


Console.ReadKey();