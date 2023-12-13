// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = 1;
int[,] arr = new int[4, 4];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = number++;
        Console.Write($"{arr[i, j] + "\t"}");
    }
    Console.WriteLine();
}

int row = ReadInt("Введите индекс строки: ");

int col = ReadInt("Введите индекс столбца: ");

if (row <= arr.GetLength(0) - 1 && col <= arr.GetLength(1) - 1)
    Console.WriteLine("Элемент массива: " + arr[row, col]);
else
    Console.WriteLine("Такого элемента нет");