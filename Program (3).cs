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

void ProductArreys(int[,] array, int[,] array1)
{
    int col = array.GetLength(1);
    int rows = array.GetLength(0);

    int col1 = array1.GetLength(1);
    int rows1 = array1.GetLength(0);

    if (col != rows1)
        Console.WriteLine("Error");
    else 
    {
        int[,] result = new int[rows, col1];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < col1; j++)
            {
                for (int k = 0; k < col; k++)
                {
                    result[i, j] += array[i, k] * array1[k, j];

                }
                Console.Write(result[i, j] + "   ");
            }
            Console.WriteLine();
        }
    }
}


Console.WriteLine("Input rows number of array 1 :");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input columns number of array 1 :");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input rows number of array 2 :");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input columns number of array 2 :");
int cols1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min numbers in massives:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max numbers in massives:");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2dArray(rows, cols, min, max);
int[,] array1 = Create2dArray(rows1, cols1, min, max);


Console.WriteLine();
Console.WriteLine("Arrey A");
Show2dArray(array);
Console.WriteLine();
Console.WriteLine("Arrey B");
Show2dArray(array1);
Console.WriteLine();
Console.WriteLine("{0,3}  ","Result Arrey = Arrey A * Arrey B");
ProductArreys(array, array1);

