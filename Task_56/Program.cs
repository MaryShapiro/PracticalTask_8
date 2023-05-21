/*
   Задача 56: Задайте прямоугольный двумерный массив. 
   Напишите программу, которая будет находить строку с наименьшей суммой элементов.
   Например, задан массив:

   1 4 7 2
   5 9 2 3
   8 4 2 4
   5 2 6 7

   Программа считает сумму элементов в каждой строке и выдаёт 
   номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

int [,] GetArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumOfLineElements(int [,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
    return sum;
}

int FindMinSumOfRows(int [,] array)
{
    int minSum = 1;
    int sum = SumOfLineElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if(sum > SumOfLineElements(array, i))
        {
            sum = SumOfLineElements(array, i);
            minSum = i + 1;
        }
    }
    return minSum;
}

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 1, 20);
Console.WriteLine("Исходный массив: ");
PrintArray(array);

Console.WriteLine($"Строка с наименьшей суммой: {FindMinSumOfRows(array)} ");
