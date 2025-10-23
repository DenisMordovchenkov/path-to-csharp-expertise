//Создание числового массива.

int[] CreateArray(int length)
{
	return new int[length];
}
;
//Заполнение массива числами от 0 до maxDigit.

void FullfillArray(int[] array, int maxDigit)
{
	for (int index = 0; index < array.Length; index++)
	{
		array[index] = Random.Shared.Next(maxDigit);
	}
}
;
//Получение суммы двузначных чисел.

int GetSumOfArray(int[] array)
{
	int sum = 0;

	for (int index = 0; index < array.Length; index++)
	{
		if (array[index] >= 10 & array[index] <= 99)
		{
			sum += array[index];
		}
	}
	return sum;
}

//Печать в консоль всех элементов массива.

string OutToConsole(int[] array)
{
	string output = string.Empty;
	for (int index = 0; index < array.Length; index++)
	{
		output += $" {Convert.ToString(array[index])}";
	}
	return output;
}

int[] array = CreateArray(10);
FullfillArray(array, 20);
int sumOfArray = GetSumOfArray(array);
Console.WriteLine(OutToConsole(array));
Console.WriteLine(sumOfArray);