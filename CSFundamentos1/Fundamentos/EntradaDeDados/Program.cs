Console.WriteLine("\n## Entrada de dados ##");

Console.WriteLine("\nInforme seu nome:");

string nome = Console.ReadLine();

Console.WriteLine("\nO seu nome é " + nome);

Console.WriteLine("\nInforme sua idade:");

int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sua idade é {idade}\n");
Console.WriteLine($"Seu nome é {nome} e sua idade é {idade} anos.");


Console.ReadKey();