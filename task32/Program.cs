// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.


Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Random r = new Random();


for (int i = 0; i < size; i++)
    array[i] = r.Next(1, 101);
for (int i = 0; i < size; i++)
    Console.Write(array[i] + "  ");

Console.WriteLine();

int count = 0;
for (int i = 0; i < size; i++)
    if (array[i] % 2 == 0)
        count++;


    Console.Write($"Количество четных чисел: {count}");
