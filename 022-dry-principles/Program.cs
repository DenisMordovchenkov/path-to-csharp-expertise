//Инициализация числового массива.
List<int> arrayOfIntegers = new List<int>();
//Инициализация переменноц для подсчёта суммы двузначных чисел.
int sum = 0;
//Заполнение массива псевдослучайными числами от 0 до 100.
for (int index = 0; index < 10; index++)
{
	int random = new Random().Next(100);
	arrayOfIntegers.Add(random);
}

//Проход по массиву с выборкой двузначных чисел и суммирования их в переменную sum.
foreach (int item in arrayOfIntegers)
{
	Console.WriteLine(item);
	if (item >= 10 & item <= 99)
	{
		sum += item;
	}
}
;
//Вывод в консоль суммы всез двузначных чисел массива.
Console.WriteLine(sum);