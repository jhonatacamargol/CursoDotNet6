Console.WriteLine("## Converção de Tipos ##\n");

int valorInt = 10;
double valorDouble = 5.35;
bool valorBool = true;

Console.WriteLine(Convert.ToString(valorInt));
Console.WriteLine(Convert.ToDouble(valorInt));
Console.WriteLine(Convert.ToString(valorBool));
Console.WriteLine(Convert.ToInt32(valorDouble));

int varInt = 100000;
Console.WriteLine(Convert.ToString(varInt));

Console.ReadKey();