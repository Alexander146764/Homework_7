/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// создаём массив
/// </summary>
int[,] array = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[i, j] = new Random().Next(0, 50);
    
    Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < rows; i++)
{
    for (int m = 0; m < cols; m++)
    {
        for (int k = m + 1; k < array.GetLength(1); k++)
        {
            if (array[i, m] < array[i, k])
            {
                int temp = array[i, m];
                array[i, m] = array[i, k];
                array[i, k] = temp;

            }
        }
    }
}

Console.WriteLine("Отсортированный массив:");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

/* Введите количество строк: 4
Введите количество столбцов: 6
49      3       2       41      28      41
5       41      49      49      11      35
18      46      34      41      14      48
39      23      30      23      39      14
Отсортированный массив:
49      41      41      28      3       2 
49      49      41      35      11      5 
48      46      41      34      18      14
39      39      30      23      23      14
PS C:\Users\poval\Desktop\Homework_7\Task1> dotnet run
Введите количество строк: 3
Введите количество столбцов: 5
36      38      15      38      24
48      28      16      23      30
40      4       46      47      31
Отсортированный массив:
38      38      36      24      15
48      30      28      23      16
47      46      40      31      4 */