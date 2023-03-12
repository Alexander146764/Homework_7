/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


int[,] array = new int[4, 4];
int value = 1;
int i, j;

int rowStart = 0, rowEnd = 3;
int colStart = 0, colEnd = 3;

while (rowStart <= rowEnd && colStart <= colEnd)
{
    for (i = colStart; i <= colEnd; i++)
    {
        array[rowStart, i] = value;
        value++;
    }
    rowStart++;

    for (i = rowStart; i <= rowEnd; i++)
    {
        array[i, colEnd] = value;
        value++;
    }
    colEnd--;

    if (rowStart <= rowEnd)
    {
        for (i = colEnd; i >= colStart; i--)
        {
            array[rowEnd, i] = value;
            value++;
        }
        rowEnd--;
    }
    if (colStart <= colEnd)
    {
        for (i = rowEnd; i >= rowStart; i--)
        {
            array[i, colStart] = value;
            value++;
        }
        colStart++;
    }
}

for (i = 0; i < 4; i++)
{
    for (j = 0; j < 4; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

/* 1       2       3       4
   12      13      14      5
   11      16      15      6
   10      9       8       7 */