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
double[] array = GetArray(int.Parse(parameters[0]), 1, 1000);
PrintArray(array);
WriteLine();
Write($"Разница между max и min элементами: {GetDiff(array):f2}");



double[] GetArray(int size, int minValue, int maxValue)
{
    double[] resultArray = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = (double)rnd.Next(minValue, maxValue + 1) / 10;
    }
    return resultArray;
}
double GetDiff(double[] inArray)
{
    double max = inArray[0];
    double min = inArray[0];
    double diff = 0;
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

void PrintArray(double[] inArray)
{
    Write("Заданный массив: [");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]:f1} ");
    }
    Write($"{inArray[inArray.Length - 1]:f1}]");
}


