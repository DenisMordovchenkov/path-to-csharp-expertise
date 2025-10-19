Console.WriteLine("Калькулятор чаевых");
Console.WriteLine("------------------");
Console.WriteLine("На сколько человек разделить счёт: ");
if (!uint.TryParse(Console.ReadLine(), out uint amountOfPeople))
{
	Console.WriteLine("Как вы себе представляете отрицательное количество человек?");
	amountOfPeople = 1;
}
Console.WriteLine("Сумма счёта: ");
if (!uint.TryParse(Console.ReadLine(), out uint bill))
{
	Console.WriteLine("Счёт не может быть отрицательным!");
}

Console.WriteLine("Сколько оставить на чай в %: ");
if (!uint.TryParse(Console.ReadLine(), out uint tipsPercentage))
{
	Console.WriteLine("Процент чаевых не может быть отрицальным");
}

uint tips = tipsPercentage * bill / 100;
uint billWithTips = bill + tips;
uint billPerPerson = billWithTips / amountOfPeople;
Console.WriteLine($"Общий счёт - {billWithTips}, Процент чаевых: {tipsPercentage}, С каждого:  - {billPerPerson}");