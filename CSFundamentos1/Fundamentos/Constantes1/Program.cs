Console.WriteLine("## Constantes ##\n");

double raio, perimetro, area;
const double PI = 3.14;

Console.WriteLine("Informe o raio do círculo");
raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * PI * raio;
area = PI * raio * raio;

Console.WriteLine($"Perimetro ={perimetro}");
Console.WriteLine($"Area ={area}");

Console.ReadKey();