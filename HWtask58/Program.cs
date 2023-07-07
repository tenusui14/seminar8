// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6
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

int[,] firstMatrix = { { 2, 4 }, { 3, 2 } };
int[,] secondMatrix = { { 3, 4 }, { 3, 3 } };



int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] powMatrix = new int[2, 2];

    for (int i = 0; i < powMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < powMatrix.GetLength(1); j++)
        {
            powMatrix[i, j] = (firstMatrix[i, j] * secondMatrix[i, j]);
        }
    }
    return powMatrix;
}
int[,] myMatrix = MultiplyMatrix(firstMatrix, secondMatrix);
PrintMatrix(myMatrix);


