uint scores = 0;

Console.WriteLine("Что означает слово 'cat'? [кошка, собака]");
if (Console.ReadLine().ToLower() == "кошка")
{
	scores += 10;
	Console.WriteLine("Всё верно!");
}
else
{
	Console.WriteLine("Нужно подумать ещё");
}

Console.WriteLine("Что означает слово 'dog'? [кошка, собака]");

if (Console.ReadLine().ToLower() == "собака")
{
	scores += 10;
	Console.WriteLine("Всё верно!");
}
else
{
	Console.WriteLine("Нужно подумать ещё");
}

Console.WriteLine($"Счёт - {scores}");