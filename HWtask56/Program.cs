// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

const int Rows = 4;
const int Columns = 4;

int[,] GetRandomMatrix(int lines, int columns)
{
    int[,] matrix = new int[lines, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(0, 10);
        }

    }

    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int FindTheLeastRowSum(int[,] matrix)
{
    int rowCount = 1;
    int temp = 9999;
    int indexLine = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum <= temp)
        {
            temp = sum;
            indexLine = i + 1;
        }
        Console.WriteLine($"Сумма эллементов {rowCount} строки = {sum}");
        rowCount++;
    }

    return indexLine;
}

int[,] myMatrix = GetRandomMatrix(Rows, Columns);
PrintMatrix(myMatrix);
Console.WriteLine($"Строка с наименьшей суммой элементов: {FindTheLeastRowSum(myMatrix)}");

