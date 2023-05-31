/*
   Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
   Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

   Массив размером 2 x 2 x 2
   66(0,0,0) 25(0,1,0)
   34(1,0,0) 41(1,1,0)
   27(0,0,1) 90(0,1,1)
   26(1,0,1) 55(1,1,1)
*/

Console.Clear();
Random rnd = new Random();

int[,,] GetArray(int m, int n, int c, int min, int max)
{
    int[,,] array = new int[m, n, c];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < c; k++)
            {
                array[i, j, k] = new Random().Next(min, max + 1);
                array[i, j, k] = GetUniqueValues(array, min, max, i, j, k);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int GetUniqueValues(int[,,] array, int min, int max, int i, int j, int k)
{
    int value = default;
    bool equalNumber = true;
    while (equalNumber)
    {
        bool _break = false;
        value = rnd.Next(min, max + 1);
        for (int i1 = 0; i1 < array.GetLength(0); i1++)
        {
            if (_break) { 
                break; }

            for (int j1 = 0; j1 < array.GetLength(1); j1++)
            {
                if (_break) { 
                    break; }

                for (int k1 = 0; k1 < array.GetLength(2); k1++)
                {
                    if (array[i1, j1, k1] == value) { 
                        _break = true; break; }

                    if (i1 == i && j1 == j && k1 == k) { 
                        equalNumber = false; }
                }
            }
        }
    }
    return value;
}

int[,,] array = GetArray(2, 2, 2, 10, 99);
PrintArray(array);