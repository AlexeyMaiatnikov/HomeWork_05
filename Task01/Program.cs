/*
Напишите программу реализующую методы формирования массива, 
заполненного случайными положительными трёхзначными числами, 
и подсчета количества чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
using static System.Console;
Clear();
Write("Введите размер массива: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] array = GetArray(int.Parse(parameters[0]), 100, 999);

PrintArray(array);
WriteLine();
Write(GetCountEven(array));



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
int GetCountEven(int[] inArray)
{
    int count = 0;
    foreach (var item in inArray)
    {
        if (item % 2 == 0) count++;
    }
    return count;
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