/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Создаём рандомный массив
/// </summary>
int[,] array = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[i, j] = new Random().Next(0, 50);
    }
}
for (int i = 0; i < rows; i++)
{
    for (int m = 0; m < cols; m++)
    {
        Console.Write(array[i, m] + "\t");
    }
    Console.WriteLine();
}

int minSumRow = 0;
int minSum = int.MaxValue;
/// <summary>
/// Ищем строчку с наименьшей суммой
/// </summary>
/// <returns>выводим номер строчки с наименьшей суммой</returns>
for (int i = 0; i < array.GetLength(0); i++)
{
    int rowSum = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        rowSum += array[i, j];
    }
    if (rowSum < minSum)
    {
        minSum = rowSum;
        minSumRow = i+1;
    }
}

Console.WriteLine("Строка с наименьшей суммой элементов: " + minSumRow + "\t");

/* Введите количество строк: 3
Введите количество столбцов: 3
25      21      9
18      9       42
26      23      22
Строка с наименьшей суммой элементов: 1
PS C:\Users\poval\Desktop\Homework_7\Task2> dotnet run
Введите количество строк: 5                                                                                                              
Введите количество столбцов: 4
8       33      18      26
2       32      35      25
4       17      37      46
21      8       1       30
3       33      44      3
Строка с наименьшей суммой элементов: 4 */