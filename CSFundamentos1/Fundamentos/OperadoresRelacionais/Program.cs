Console.WriteLine("## Operadores Relacionais ##\n");

int x = 10, y = 20;

Console.WriteLine($"Valor de x é {x}");
Console.WriteLine($"Valor de y é {y}");

bool resultado = x == y;
Console.WriteLine(resultado);


Console.WriteLine(x == y);
Console.WriteLine(x > y);
Console.WriteLine(x < y);
Console.WriteLine(x >= y);
Console.WriteLine(x <= y);
Console.WriteLine(x != y);

string a = "\"Curso c#\"";
string b = "\"curso c#\"";

Console.WriteLine($"Valor a é {a}");
Console.WriteLine($"Valor b é {b}");

Console.WriteLine(a == b);
Console.WriteLine(a.Equals(b));

Console.ReadKey();