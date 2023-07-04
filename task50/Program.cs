// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

const int Rows = 3;
const int Columns = 4;

int[,] GetRandomMatrix(int lines, int columns)
{
    int[,] matrix = new int[lines, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 1000);
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

void ChangeFirstAndLastRow(int[,] matrix)
{

    int rowCount = matrix.GetLength(0);
    int columnCount = matrix.GetLength(1);

    for (int j = 0; j < columnCount; j++)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[rowCount - 1, j];
        matrix[rowCount - 1, j] = temp;
    }

}

int[,] myMatrix = GetRandomMatrix(Rows,Columns);
PrintMatrix(myMatrix);
Console.WriteLine();
ChangeFirstAndLastRow(myMatrix);
PrintMatrix(myMatrix);