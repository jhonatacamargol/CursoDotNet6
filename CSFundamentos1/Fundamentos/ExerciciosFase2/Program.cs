Console.WriteLine("## Exercícios fase 2 ##\n");

string nome = "Paulo";
double idade = 17, nota = 7.5;

Console.WriteLine($"Aluno {nome} \ntem {idade} anos \ne sua nota foi {nota}.\n");

Console.WriteLine("Escolha uma letra");
string primeiraLetra = Console.ReadLine();

Console.WriteLine("Escolha outra letra");
string segundaLetra = Console.ReadLine();

Console.WriteLine("Escolha outra letra");
string terceiraLetra = Console.ReadLine();

Console.WriteLine($"O resulado reverso é {terceiraLetra},{segundaLetra} e {primeiraLetra}.\n");

Console.WriteLine("Digite primeiro número");
double pnumero = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite segundo número");
double snumero = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"O resultado da soma é {pnumero + snumero}.\n");
Console.WriteLine($"O resultado da subtração é {pnumero - snumero}\n");
Console.WriteLine($"O resultado da multiplicação é {pnumero * snumero}\n");
Console.WriteLine($"O resultado da divisão é {pnumero / snumero}\n");
Console.WriteLine($"O resultado do módulo é {pnumero % snumero}\n");

string nome1 = "admin", nome2 = "maria";

Console.WriteLine("Digite seu nome:");
string nomel = Console.ReadLine();
int senhar = 123;

Console.WriteLine("Digite sua senha:");
int senha = Convert.ToInt32(Console.ReadLine());

string result = nomel == nome1 && senha == senhar ? "Login feito com sucesso!" :
                 nomel == nome2 && senha == senhar ? "Login feito com sucesso!" :
                 "Login inválido!";

Console.WriteLine(result);

Console.Write("Digite o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

string xResult = x % 2 == 0 ? $"O número {x} é par" : $"O número {x} é ímpar";
string yResult = y % 2 == 0 ? $"O número {y} é par" : $"O número {y} é ímpar";


Console.WriteLine(xResult);
Console.WriteLine(yResult);

var numero = 5;
Console.WriteLine(numero++);
numero = 1;
Console.WriteLine(++numero);
numero = 2;
Console.WriteLine(numero--);
numero = 3;
Console.WriteLine(--numero);

Console.ReadKey();