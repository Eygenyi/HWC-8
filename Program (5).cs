int[,] Create2dArray(int rows, int col)
{
    int[,] array = new int[rows, col];

    int k = 1;
    int t = 0;
    int i = 0;
    int j = 0;

    int n = col;
    int m = rows;

    while (k <= n * m)
    {

        for (i = t; i < col; i++)
            array[j, i] = k++;
        j = col - 1;
        for (i = t + 1; i < rows; i++)
            array[i, j] = k++;
        j = rows - 1;
        for (i = col - 2; i >= t; i--)
            array[j, i] = k++;
        j = t;
        for (i = rows - 2; i > t; i--)
            array[i, j] = k++;
        col--;
        rows--;
        t++;
        j = t;
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,2}  ", array[i, j]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input rows number");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input columns number");
int col = Convert.ToInt32(Console.ReadLine());

Show2dArray(Create2dArray(rows, col));