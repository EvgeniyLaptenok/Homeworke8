/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите p");
int p = int.Parse(Console.ReadLine()!);


int[,,] matrix = Create3DArray(m, n, p, 10, 99);
Print2DArray(matrix);




int[,,] Create3DArray(int m, int n, int p, int min, int max)
{
    int[,,] matrix = new int[p, m, n];
    bool[] array = new bool[100];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(min, max + 1);

                if (!array[matrix[i, j, k]])
                {
                    array[matrix[i, j, k]] = true;
                }
                else
                {
                    k--;
                }
            }
           
        }
    }
    return matrix;
}

void Print2DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            Console.Write($"{matrix[i, j, k]}({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}