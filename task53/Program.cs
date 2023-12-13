// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int rows = ReadInt("Введите количество строк в матрице: ");

int cols = ReadInt("Введите количество столбцов в матрице: ");

int[,] matrix = GenerateMatrix(rows, cols, 1, 9);

PrintMatrix(matrix);

System.Console.WriteLine();

int sumRow(int[,] array, int i)
{
    int sum = array[i,0];
    for(int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

int minSum = 1;
int sum = sumRow(matrix, 0);
for(int i = 0; i < matrix.GetLength(0); i++)
{
    if(sum > sumRow(matrix, i))
    {
        sum = sumRow(matrix, i);
        minSum = i+1;
    }
}

Console.WriteLine($"Строка с наименьшей суммой элементов: {minSum}");