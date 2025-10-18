
Console.WriteLine("Калькулятор чаевых");
Console.WriteLine("------------------");
Console.WriteLine("Укажите на сколько человек разделить счёт: ");
string amountOfPeople = Console.ReadLine();
Console.WriteLine("Укажите сумму счёта: ");
string bill = Console.ReadLine();
Console.WriteLine("Укажите сколько оставить на чай в %: ");
string tipsPercentage = Console.ReadLine();
int.TryParse(amountOfPeople, out int intAmountOfPeople);
int.TryParse(bill, out int intBill);
int.TryParse(tipsPercentage, out int intTipsPercentage);
int tips = (intTipsPercentage * intBill) / 100;
int billWithTips = intBill + tips;
int billPerPerson = billWithTips / intAmountOfPeople;
Console.WriteLine($"Общий счёт - {billWithTips}, Процент чаевых: {tipsPercentage}, С каждого:  - {billPerPerson}");