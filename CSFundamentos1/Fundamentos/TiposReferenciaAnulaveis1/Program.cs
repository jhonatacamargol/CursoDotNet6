Console.WriteLine("## Tipos de referência Anuláveis ##\n");

//modo não correto
//string nome = null;
//Console.WriteLine(nome.ToUpper());

//modo correto
string? nome = null;
Console.WriteLine(nome?.ToUpper());

//ou
string nome1 = "";
Console.WriteLine(nome1?.ToUpper());

Console.ReadKey();