/*
Напишите программу реализующую методы формирования массива, 
заполненного случайными вещественными числами и вычисления разницы между 
максимальным и минимальным элементов массива.
[3,3 7,1 22,5 2,2 78,2] -> 76
*/
using static System.Console;
Clear();
Write("Введите размер массива: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] array = GetArray(int.Parse(parameters[0]), 1, 100);
PrintArray(array);
WriteLine();
Write($"Разница между max и min элементами: {GetDiff(array)}");



int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(minValue, maxValue + 1);
    }
    return resultArray;
}
int GetDiff(int[] inArray)
{
    int max = inArray[0];
    int min = inArray[0];
    int diff = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (max < inArray[i])
        {
            max = inArray[i];
        }
        if (min > inArray[i])
        {
            min = inArray[i];
        }
        diff = max - min;
    }
    return diff;
}

void PrintArray(int[] inArray)
{
    Write("Заданный массив: [");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}


