Console.WriteLine("введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] matrix = GetArray(rows, colums, 0, 99);
PrintArray(matrix);
Console.WriteLine();
SortArray(matrix);

int [,] GetArray(int m, int n, int minvalue, int maxvalue)
{
    int [,] result = new int [m, n];
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            
            result[i,j] = new Random().Next(minvalue, maxvalue+1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int a = 0; a < array.GetLength(1) - 1; a++)
      {
        if (array[i, a] < array[i, a + 1])
        {
          int temp = array[i, a + 1];
          array[i, a + 1] = array[i, a];
          array[i, a] = temp;
        }
      }
    }
  }
  PrintArray(array);
}