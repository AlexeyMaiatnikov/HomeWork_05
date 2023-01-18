/*
Напишите программу реализующую методы формирования массива, 
заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
using static System.Console;
Clear();
Write("Введите размер массива: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] array = GetArray(int.Parse(parameters[0]), 1, 100);
PrintArray(array);
WriteLine();
Write($"Сумма элементов на нечетных позициях: {GetSumOddIndex(array)}");



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
int GetSumOddIndex(int[] inArray)
{
    int sum = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + inArray[i];
        };
    }
    return sum;
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