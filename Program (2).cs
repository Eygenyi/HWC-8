void MinSumCols(int[,] farrey)
{


    int minsum = 0;
    int minrow=0;

    for (int i = 0; i < farrey.GetLength(0); i++)

    {

        int sum = 0;

        for (int j = 0; j < farrey.GetLength(1); j++)
        {

            sum += farrey[i, j];

        }
        if (minsum > sum)
        {
            minsum = sum;
            minrow=i;
        }
        if (minsum == 0)
            minsum = sum;
        Console.WriteLine("Sum of column " + i + "  =   " + sum);
   }

    Console.WriteLine("Minimal sum elements in row  "+minrow+"  =  "+minsum);
  
    

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
Show2dArray(array);
MinSumCols(array);

