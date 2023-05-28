/*
   Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
   Например, даны 2 матрицы:
   2 4 | 3 4
   3 2 | 3 3
   Результирующая матрица будет:
   18 20
   15 18
*/

Console.Clear();

int[,] GetArray(int m, int n, int min, int max)
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

int[,] ProductOfMatrices(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array3.GetLength(0); i++)
        {
            for (int j = 0; j < array3.GetLength(1); j++)
            {
                array3[i, j] = 0;
                for (int n = 0; n < array1.GetLength(1); n++)
                {
                    array3[i, j] += array1[i, n] * array2[n, j];
                }
            }
        }
    }
    return array3;
}

Random rnd = new Random();
int[,] array1 = GetArray(rnd.Next(2, 4), rnd.Next(2, 4), 0, 9);
int[,] array2 = GetArray(rnd.Next(2, 4), rnd.Next(2, 4), 0, 9);

Console.WriteLine("Матрица 1: ");
PrintArray(array1);
Console.WriteLine();

Console.WriteLine("Матрица 2: ");
PrintArray(array2);
Console.WriteLine();

Console.WriteLine("Произведение матриц: ");
PrintArray(ProductOfMatrices(array1, array2));
Console.WriteLine();
