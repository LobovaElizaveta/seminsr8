Console.WriteLine("введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!);

int [,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);

int row = 0;
int sum = FindSum(array,0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = FindSum(array,i);
  if (sum > temp)
  {
    sum = temp;
    row = i;
  }
}

Console.WriteLine($"Строка {row} с наименьшей суммой элементов {sum}");

///////////////////////////////////////////////////////////////////
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

int FindSum(int[,] array, int i)
 {
 int sum = array[i,0];
   for (int j = 1; j < array.GetLength(1); j++)
      {
    sum += array[i,j];
  }
   return sum;
}