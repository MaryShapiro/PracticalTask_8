/*  
   Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
   Например, на выходе получается вот такой массив:
   01 02 03 04
   12 13 14 05
   11 16 15 06
   10 09 08 07
*/

Console.Clear();

Console.WriteLine("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = GetSpiralArray(n);
PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine(" ");
    }
}

int[,] GetSpiralArray(int n)
{
    int[,] array = new int[n, n];
    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = num;
        num++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return array;
}
