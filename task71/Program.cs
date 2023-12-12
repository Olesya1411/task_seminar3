// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int M, int N)
{
    if (M > N)
        return;
    Console.Write(M + "\t");
    PrintNumbers(M + 1, N);
}

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
PrintNumbers(M, N);
