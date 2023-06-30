Console.WriteLine("## Instrução if ##\n");

Console.WriteLine("Cliente especial (true/false)");
var resposta = Convert.ToBoolean(Console.ReadLine());

if (resposta)
{
    Console.WriteLine("DESCONTO DE 10%");
}
Console.WriteLine("Fim do processamento");


Console.WriteLine("Informe o valor de x\n");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y\n");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("x é maior que y");
} if (x < y)
{
    Console.WriteLine("x é menor que y");
} if (x ==  y)
{
    Console.WriteLine("x é igual a y");
}

Console.ReadKey();