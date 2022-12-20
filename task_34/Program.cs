// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] resultArray = GetArray(10, 100, 999);
Console.WriteLine(String.Join(", ", resultArray));

int GetEven(int[] array)
{
    int evenNamber = 0;

        for (int i = 0; i < resultArray.Length; i++)
        {
            if (resultArray[i] % 2 == 0)
            {
                evenNamber++;
            }
        }
        return evenNamber;
}

int result = GetEven(resultArray);
Console.WriteLine($"Количество чётных чисел: {result}");