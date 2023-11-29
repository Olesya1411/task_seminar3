// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = new double[size];
Random rand = new Random();

for (int i = 0; i < size; i++)
    array[i] = Math.Round((double)rand.Next(1, 5) + rand.NextDouble(), 2);
for (int i = 0; i < size; i++)
    Console.Write(array[i] + "  ");

Console.WriteLine();

double min = double.MaxValue;
double max = double.MinValue;

for (int i = 0; i < size; i++){
    if (array[i] < min)
        min = array[i];
    if (array[i] > max)
        max = array[i];
}

double diff = max - min;

Console.Write($"Разница между {max} и {min}: {diff}");