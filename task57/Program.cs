//  Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается
//   элемент входных данных. Элементы [0, 9]
//  Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

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

int[] GetFrequencyElementsMatrix(int[,] matrix) // Сортировка подсчётом 
{
    int[] frequencyArray = new int[10];
    int rowCount = matrix.GetLength(0);
    int columnCount = matrix.GetLength(1);
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
        {
            frequencyArray[matrix[i, j]]++;
        }
    }
    return frequencyArray;
}

int[,] myMatrix = GetRandomMatrix(Rows,Columns);
PrintMatrix(myMatrix);
Console.WriteLine();
int[] myArray = GetFrequencyElementsMatrix(myMatrix);
for(int i = 0; i < myArray.Length; i++){
    Console.Write($"Элемент {i} встречается {myArray[i]}");
    Console.WriteLine();
}

