Console.WriteLine("## Operadores Uniários e Ternários ##\n");

int positivo = 1;
int resultado;

resultado = +positivo;
Console.WriteLine(resultado);

Console.WriteLine("Informe um número:\n");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo de {n} é {-n}");

Console.WriteLine("\nInforme a temperatura:\n");
var temp = Convert.ToDouble(Console.ReadLine());

var result = temp >= 30 ? "Quente" : "Normal";

Console.WriteLine("O Tempo está " + result + ".\n");


Console.WriteLine("Informe o valor de \'x\'\n");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de \'y\'\n");
int y = Convert.ToInt32(Console.ReadLine());

string resultar = x > y ? "\'xé maior que y\'\n" :
                  x < y ? "\'x é menor que y\'\n" :
                  x == y ? "\'x é igual a y\'" : "Sem resultado";

Console.WriteLine(resultar);

Console.ReadKey();