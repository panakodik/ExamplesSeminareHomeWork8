﻿// Составить частотный словарь элементов двумерного массива

/*Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Пример: Есть набор данных

{ 1, 9, 9, 0, 2, 8, 0, 9 }

частотный массив может быть представлен так:

0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

Если набор данных - таблица

1, 2, 3
4, 6, 1
2, 1, 6

на выходе ожидаем получить

1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза

Пример частотного массива для текстовых данных: Входные данные:

Частотный анализ – это один из методов криптоанализа, основывающийся на предположении о существовании нетривиального статистического распределения отдельных символов и их последовательностей как в открытом тексте, так и шифрованном тексте, которое с точностью до замены символов будет сохраняться в процессе шифрования и дешифрования.

Частотный анализ может выглядеть так

Символ пробел/space встречается 41 раз. Част
Олег Голенищев: Символ я встречается 6 раз. Частота 1.80%
Символ м встречается 6 раз. Частота 1.80%
Символ ь встречается 5 раз. Частота 1.50%
Символ ы встречается 5 раз. Частота 1.50%
Символ з встречается 4 раза. Частота 1.20%
Символ х встречается 3 раза. Частота 0.90%
Символ ш встречается 3 раза. Частота 0.90%
Символ ф встречается 3 раза. Частота 0.90%
Символ ч встречается 3 раза. Частота 0.90%
Символ й встречается 3 раза. Частота 0.90%
Символ , встречается 3 раза. Частота 0.90%
Символ щ встречается 2 раза. Частота 0.60%
Символ ю встречается 2 раза. Частота 0.60%
Символ у встречается 2 раза. Частота 0.60%
Символ г встречается 2 раза. Частота 0.60%
Символ ж встречается 1 раз. Частота 0.30%
Символ э встречается 1 раз. Частота 0.30%
Символ – встречается 1 раз. Частота 0.30%
Символ б встречается 1 раз. Частота 0.30%
Символ ц встречается 1 раз. Частота 0.30%
Символ . встречается 1 раз. Частота 0.30%*/

//Задача №1

Console.WriteLine("Задайте длинну массива");
int n = int.Parse(Console.ReadLine()!);
void Massive()
{
    Console.WriteLine("Массив");
}

void PrintArray(int[] array)
{ 
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
    Console.WriteLine();
}    

void FillArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        array[j] = new Random().Next(1,10);
    }
}

void SortArray(int[] array)
{
    Array.Sort(array);
        Console.WriteLine("\nПо возрастанию: ");
          foreach(int value in array)
                {
                    Console.Write(value + " ");
                }
}

void ReversetArray(int[] array)
{
        // Отсортировать массив в порядке возрастания
    Array.Reverse(array);
        //Console.WriteLine("\n\nПо убыванию: ");
        // вывести все элементы массива
            foreach(int value in array)
                {
                    //Console.Write(value + " ");
                }
}

void CountingNumber(int[] array)
{
int count = 1;
for (int i = 0; i < array.Length-1; i++)
    {
    int n = array[i];
        if(n == array[i+1])
        {
            count++;
        }
        else
        {
            Console.WriteLine("Элемент "+ array[i]+ " встречается в массиве " + (count) + " раз(а)");
            count = 1;
        }
            
    }
}

void CountingReverseEndNumber(int[] array)
{
    int count = 1;
        
        for (int i = 0; i < array.Length-1; i++)
        {
            int n = array[i];
            if(n == array[i+1])
            {
                count++;
            }
            else
            {
                Console.WriteLine("Элемент "+ array[i]+ " встречается в массиве " + (count) + " раз(а)");
                break;
                count = 1;
            
            }
        }
}

int[] arr = new int[n];
FillArray(arr);
Massive();
PrintArray(arr);
Console.WriteLine("---------");

Massive();
SortArray(arr);
Console.WriteLine();
Console.WriteLine("---------");
CountingNumber(arr);
ReversetArray(arr);
CountingReverseEndNumber(arr);


