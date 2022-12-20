// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double minValue = 0;
double maxValue = 1;

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble(), 2);
    }
    return array;
}

double[] resultArray = GetArray(5, minValue, maxValue);
Console.WriteLine($"[{string.Join(", ", resultArray)}]");

void GetDiff(double[] array, double minValue, double maxValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i]; 
        }
        else if (array[i] > maxValue)
        {
            maxValue = array[i];
        }
    }
    Console.Write($"Разница между максимальным и минимальным элементами массива: {maxValue-minValue}");
}

GetDiff(resultArray, maxValue, minValue);