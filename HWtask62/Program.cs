// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix = new int[4, 4];

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

int iterator = 1;

for (int i = 0; i < matrix.GetLength(1); i++)
{
    matrix[0, i] = iterator;
    iterator += 1;
}
for (int i = 1; i < matrix.GetLength(0); i++)
{
    matrix[i, matrix.GetLength(1) - 1] = iterator;
    iterator += 1;
}
for (int i = 2; i > 0; i--)
{
    matrix[matrix.GetLength(0) - 1, i] = iterator;
    iterator += 1;
}
for (int i = 3; i > 0; i--)
{
    matrix[i, 0] = iterator;
    iterator += 1;
}
for (int i = 1; i < matrix.GetLength(1) - 1; i++)
{
    matrix[1, i] = iterator;
    iterator += 1;
}
for (int i = 2; i > 0; i--)
{
    matrix[2, i] = iterator;
    iterator += 1;
}

PrintMatrix(matrix);