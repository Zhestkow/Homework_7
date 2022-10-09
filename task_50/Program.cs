// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет



using static System.Console;
Clear();
Write("Ввдеите количество строк, столбцов, минимальное и максимальное значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(matrix);
Write("Ввдеите позицию элемента в двумерном массиве через пробел:  ");
int[] NumIdx = GetArrayFromString(ReadLine()!);
if (NumIdx[0] > matrix.GetLength(0) || NumIdx[1] > matrix.GetLength(1))
{
    WriteLine("Такого элемента нет!!!");
}
else 
{
     Write($"{matrix[NumIdx[0],NumIdx[1]]}");
}






int[,] GetMatrixArray(int rows, int coloms, int minValue, int maxValue)
{
    int[,] MatrixArray = new int[rows, coloms];
    for (int i = 0; i < MatrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixArray.GetLength(1); j++)
        {
            MatrixArray[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return MatrixArray;
}


void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]} ");
        }
        WriteLine();
    }
}


int[] GetArrayFromString(string parameters)
{
    string[] parametr = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] parametrNum = new int[parametr.Length];
    for (int i = 0; i < parametrNum.Length; i++)
    {
        parametrNum[i] = int.Parse(parametr[i]);
    }
    return parametrNum;
}