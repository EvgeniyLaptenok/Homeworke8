/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.WriteLine("Введите число строк 1-й матрицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов 2-й матрицы: ");
int p = int.Parse(Console.ReadLine()!);

// int[,] firstMartrix = new int[m, n];
// CreateArray(firstMartrix);
// Console.WriteLine($"\nПервая матрица:");
// WriteArray(firstMartrix);

// int[,] secomdMartrix = new int[n, p];
// CreateArray(secomdMartrix);
// Console.WriteLine($"\nВторая матрица:");
// WriteArray(secomdMartrix);

// int[,] resultMatrix = new int[m,p];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"\nПроизведение первой и второй матриц:");
// WriteArray(resultMatrix);

int[,] matrixFirst = Create2DArrayFirst(m, n, 0, 10);
Print2DArrayFirst(matrixFirst);
Console.WriteLine();
int[,] matrixSecond = Create2DArraySecond(n, p, 0, 10);
Print2DArraySecond(matrixSecond);
Console.WriteLine();
int[,] emptyMatrix = new int[m, p];
MatrixProduct(matrixFirst, matrixSecond, emptyMatrix);
Print2DArrayEmpty(emptyMatrix);


int[,] MatrixProduct(int[,] matrixFirst, int[,] matrixSecond, int[,] emptyMatrix)
{
    
    for (int i = 0; i < emptyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < emptyMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixFirst.GetLength(1); k++)
            {
            sum += matrixFirst[i,k] * matrixSecond[k,j];
            }
            emptyMatrix[i,j] = sum;
        }
    }
    return emptyMatrix;
}

int[,] Create2DArraySecond(int n, int p, int min, int max)
{
    int[,] matrixSecond = new int[n, p];

    for (int i = 0; i < matrixSecond.GetLength(0); i++)
    {
        for (int j = 0; j < matrixSecond.GetLength(1); j++)
        {
            matrixSecond[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrixSecond;
}


int[,] Create2DArrayFirst(int m, int n, int min, int max)
{
    int[,] matrixFirst = new int[m, n];

    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFirst.GetLength(1); j++)
        {
            matrixFirst[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrixFirst;
}

void Print2DArrayFirst(int[,] matrixFirst)
{
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFirst.GetLength(1); j++)
        {
            Console.Write(matrixFirst[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Print2DArraySecond(int[,] matrixSecond)
{
    for (int i = 0; i < matrixSecond.GetLength(0); i++)
    {
        for (int j = 0; j < matrixSecond.GetLength(1); j++)
        {
            Console.Write(matrixSecond[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Print2DArrayEmpty(int[,] emptyMatrix)
{
    for (int i = 0; i < emptyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < emptyMatrix.GetLength(1); j++)
        {
            Console.Write(emptyMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}