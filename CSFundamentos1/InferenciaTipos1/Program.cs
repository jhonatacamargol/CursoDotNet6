Console.WriteLine("## Inferência Tipos (var) ##\n");

int idade = 25;
string nome = "Maria";
decimal salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")} por mês.\n");

var idade1 = 30;
var nome1 = "Maria";
var salario1 = 3500.00m;

Console.WriteLine($"{nome1} tem {idade1} anos e ganha {salario1.ToString("c")} por mês.\n");

Console.ReadKey();