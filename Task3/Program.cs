/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
/// <summary>
/// вводим данные двух матриц
/// </summary>
/// <value></value>
int[,] matrix1 = new int[,] { { 2, 4 }, { 3, 2 } };
int[,] matrix2 = new int[,] { { 3, 4 }, { 3, 3 } };

int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
/// <summary>
/// перемножение матриц
/// </summary>
/// <returns>получается новая матрица</returns>
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}

Console.WriteLine("Результат умножения матриц:");
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        Console.Write(resultMatrix[i, j] + "\t");
    }
    Console.WriteLine();
}

/* Результат умножения матриц:
18      20
15      18 */