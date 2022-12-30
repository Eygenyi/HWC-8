int[,,] Create3dArray(int z, int x, int y)
{
    int[,,] array = new int[z, x, y];

    int f = array.GetLength(0) * array.GetLength(1) * array.GetLength(2);
    int l = 10;
    int i, j, k;
    while (l < f)
    {

        for (i = 0; i < array.GetLength(0); i++)
        {
            for (j = 0; j < array.GetLength(1); j++)
            {
                for (k = 0; k < array.GetLength(2); k++)
                    array[k, j, i] = l++;
            }
        }

    }
    return array;
}
void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("{0,3}  ", array[i, j, k] + "(" + i + "," + j + "," + k + ")" + "  ");

            }
            Console.WriteLine();
        }

    }
}
Console.WriteLine("Input x number of array :");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y number of array :");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z number of array :");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array = Create3dArray(x, y, z);

Console.WriteLine();
Show3dArray(array);

