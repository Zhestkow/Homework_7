// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



using static System.Console;
Clear();
Write("Ввдеите количество строк, столбцов через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
double[,] matrix = GetMatrixArray(parameters[0], parameters[1]);
PrintMatrix(matrix);











double[,] GetMatrixArray(int rows, int coloms)
{
    double[,] MatrixArray = new double[rows, coloms];
    for (int i = 0; i < MatrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixArray.GetLength(1); j++)
        {
            MatrixArray[i, j] = Convert.ToDouble(new Random().Next(-100,100));
        }
    }
    return MatrixArray;
}


void PrintMatrix(double[,] inMatrix)
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