Console.WriteLine("Saída de dados : Formatação");
Console.WriteLine();

int idade  = 25;
string nome = "Maria";
Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine();

//Escreva na mesma linha 'Maria tem 25 anos'
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.WriteLine(" anos.");
Console.WriteLine("*------------concatenação-----------------*");

//Usar a concatenação : usando o operador +
Console.WriteLine(nome + " tem " + idade + " anos.");
Console.Write(nome + " tem " + idade + " anos.");
Console.WriteLine();
Console.WriteLine("*------------interpolação-----------------*");

//usa a interpolação de strings : $ -> a interpolação {}
Console.WriteLine($"{nome} tem {idade} anos.");

Console.WriteLine("*------------place houters-----------------*");


//usar place holders : usa {} com numeração com início em zero
Console.WriteLine("{0} tem {1} anos.", nome, idade);


Console.ReadLine();