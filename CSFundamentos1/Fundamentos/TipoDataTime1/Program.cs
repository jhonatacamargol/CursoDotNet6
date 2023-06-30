Console.WriteLine("## Struct DataTime ##\n");

DateTime hoje = DateTime.Now;
Console.WriteLine($"hoje : {hoje}\n");

//extrair informações da data atual
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);

//adcionando valores
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddHours(2));
Console.WriteLine(hoje.AddYears(5));

//obter o dia da semana e do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

//data formato longo e curto
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());

//criar uma data específica usa formato: aaaa,mm,dd
DateTime DataHoje = new DateTime(2023, 10, 01);
Console.WriteLine(DataHoje);

//Definir horas
DateTime DataHoraHoje = new DateTime(2023, 10, 01, 21, 10, 30);
Console.WriteLine(DataHoraHoje);

Console.ReadKey();