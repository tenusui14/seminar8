// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший
//  элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

const int Rows = 5;
const int Columns = 5;

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

int[] GetMinPosition(int[,] matrix)
{
    int iPositionMin = 0;
    int jPositionMin = 0;
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                iPositionMin = i;
                jPositionMin = j;
            }
        }
    }
    int[] arrayPair = new int[] { iPositionMin, jPositionMin };
    return arrayPair;
}

int[,] RemoveMinPositionRawAndColumn(int[,] matrix, int[] arrayToRemove)
{
    int[,] redactedMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int iShift = 0;
    int jShift = 0;
    for (int i = 0; i < redactedMatrix.GetLength(0); i++)
    {
        if (i == arrayToRemove[0])
            {
                iShift++;
            }
        for (int j = 0; j < redactedMatrix.GetLength(1); j++)
        {
            
            if (j == arrayToRemove[1])
            {
                jShift++;
            }
            redactedMatrix[i,j] = matrix[i + iShift, j + jShift];
        }
        jShift = 0;
    }
    return redactedMatrix;
}

int[,] myMatrix = GetRandomMatrix(Rows, Columns);
int[] array = GetMinPosition(myMatrix);
PrintMatrix(myMatrix);
Console.WriteLine();
int[,] reducedMatrix = RemoveMinPositionRawAndColumn(myMatrix, array);
PrintMatrix(reducedMatrix);