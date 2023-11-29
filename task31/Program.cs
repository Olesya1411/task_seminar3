// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].


Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Random r = new Random();
int startRange = 20;
int endRange = 90;


for (int i = 0; i < size; i++)
    array[i] = r.Next(1, 101);
for (int i = 0; i < size; i++)
    Console.Write(array[i] + "  ");


Console.WriteLine();

int count = 0;
for (int i = 0; i < size; i++)
    if (array[i] >= startRange && array[i] <= endRange)
        count++;


    Console.Write($"Количество чисел в диапазоне от {startRange} до {endRange}: {count}");
