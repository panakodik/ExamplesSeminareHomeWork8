// В двумерном массиве целых чисел. Удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент
Console.WriteLine("Задайте число равное количеству строк двумерного массива");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте число равное количеству столбцов двумерного массива");
int n = int.Parse(Console.ReadLine()!);
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
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

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int x = 0;
int y = 0;
int min = array[0, 0];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < min)
        {
            min = array[i, j];
            x = i;
            y = j;
        }
    }
}
Console.WriteLine("Наименьший элемент: " + min);

Console.WriteLine("Вывод преобразованной матрицы");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        {
            if ((i == x) || (j == y))
                continue;
            else
                Console.Write(array[i, j] + " ");
        }
    }
    Console.WriteLine();
}

