int[,] ChengeArray(int[,] array)
{
    int minmax;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int f = 0; f < j; f++)
            {
                if (array[i, j] < array[i, f])
                {
                    minmax = array[i, j];
                    array[i, j] = array[i, f];
                    array[i, f] = minmax;
                }
            }

        }

    }
    return array;
}


int[,] Create2dArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}


void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input rows number :");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input columns number :");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min numbers in massive:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max numbers in massive:");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2dArray(rows, cols, min, max);

Console.WriteLine();
Show2dArray(array);
int[,] array2 = ChengeArray(array);
Console.WriteLine();
Console.WriteLine("Ordered arrey is");
Console.WriteLine();
Show2dArray(array2);
Console.WriteLine();
