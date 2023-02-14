﻿// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
Console.Clear();
void Print3dArray(int[,,] arr, string preStr = "", string postStr = "\n") // Выводит на экран элементы трехмерного массива с индексами
{
 Console.Write(preStr);
 for (int i = 0; i < arr.GetLength(0); i++)
    {
 for (int j = 0; j < arr.GetLength(1); j++)
            {
 for (int k = 0; k < arr.GetLength(2); k++)
 Console.Write($"({i},{j},{k}: - {arr[i, j, k]}) ");
 Console.WriteLine();
            }
 Console.WriteLine();
    }
 Console.Write(postStr);
}

bool IsFill3dArray(int[,,] arr) // Возращает заполненный трехмерный массив двухзачными не потвторяющимися числами. Если получилось возращает true, иначе false.
{
 if (arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2) < 99)
    {
 int fillValue = 10; // Первое двухнзначное значение для подстановки. Неповторяемость обеспечиваем тем что каждое следующее будет больше на 1
 for (int i = 0; i < arr.GetLength(0); i++)
 for (int j = 0; j < arr.GetLength(1); j++)
 for (int k = 0; k < arr.GetLength(2); k++)
                {
 arr[i, j, k] = fillValue;
 fillValue++;
                }
 return true;
    }
 else return false;
}

Console.WriteLine("Задайте число равное количеству строк двумерного массива");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте число равное количеству столбцов двумерного массива");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте число равное количеству столбцов двумерного массива");
int k = int.Parse(Console.ReadLine()!);

{
  int[,,] tstArr = new int[m, n, k];
 if (IsFill3dArray(tstArr)) Print3dArray(tstArr, preStr: "Трехмерный массив: \n", postStr: "");
 else Console.Write($"Заполнить трехмерный массив размера {m}x{n}x{k} невовторяющимися двухзначными числами невозможно!");
}
