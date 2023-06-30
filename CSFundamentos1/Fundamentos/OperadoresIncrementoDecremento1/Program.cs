Console.WriteLine("## Operadores Incremento e Decremento ##\n");

int x = 0;
Console.WriteLine($"x = {x}");

//pós-incremento -> primeiro resolve depois incrementa
int resultado1 = x++ + 10;
Console.WriteLine($"pós-incremento ==> {resultado1}");
Console.WriteLine($"valor de x ==> {x}\n");

//pós-decremento -> primeiro resolve depois decrementa
int x1 = 0;
Console.WriteLine($"x = {x1}");
int resultado1d = x1-- + 10;
Console.WriteLine($"pós-decremento ==> {resultado1d}");
Console.WriteLine($"valor de x ==> {x1}\n");

//pré-incremento -> primeiro incrementa depois resolve
int y = 0;
Console.WriteLine($"y ==> {y}");

int resultado2 = ++y + 10;
Console.WriteLine($"pré-incremento ==> {resultado2}");
Console.WriteLine($"valor de x ==> {y}\n");

//pré-decremento -> primeiro decrementa depois resolve
int y1 = 0;
Console.WriteLine($"y ==> {y1}");
int resultado2d = --y1 + 10;
Console.WriteLine($"pré-decremento ==> {resultado2d}");
Console.WriteLine($"valor de x ==> {y1}\n");

Console.ReadKey();