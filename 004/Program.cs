//Найти произведение двух матриц
Console.WriteLine("Задайте число равное количеству строк двумерного массива");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте число равное количеству столбцов двумерного массива");
int n = int.Parse(Console.ReadLine()!);
void FillArray(int[,] matr, int[,] matr1)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matr1[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr, int[,] matr1)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            Console.Write($"{matr1[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Composition(int[,] matr, int[,] matr1, int[,] compMatr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            compMatr[i, j] = matr[i, j] * matr1[i, j];
        }
    }
}

void PrintCompArray(int[,] compMatr)
{
    for (int i = 0; i < compMatr.GetLength(0); i++)
    {
        for (int j = 0; j < compMatr.GetLength(1); j++)
        {
            Console.Write($"{compMatr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[m, n];
int[,] matrix1 = new int[m, n];
int[,] compMatrix = new int[m, n];
FillArray(matrix, matrix1);
PrintArray(matrix, matrix1);
Console.WriteLine();
Composition(matrix, matrix1, compMatrix);
PrintCompArray(compMatrix);