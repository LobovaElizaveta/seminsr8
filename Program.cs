Console.WriteLine("введите количество строк первой матрицы: ");
int rows1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите количество столбцов первой матрицы: ");
int colums1 = int.Parse(Console.ReadLine()!);

int[,] matrix1 = GetArray(rows1, colums1, 0, 10);

Console.WriteLine("введите количество строк второй матрицы: ");
int rows2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите количество столбцов второй матрицы: ");
int colums2 = int.Parse(Console.ReadLine()!);

int[,] matrix2 = GetArray(rows2, colums2, 0, 10);

Console.WriteLine("Первая матрица");
PrintArray(matrix1);
Console.WriteLine("Вторая матрица");
PrintArray(matrix2);

if(rows1!= colums2)
{
    Console.WriteLine("Такие матрицы нельзя умножать");
}

Console.WriteLine("Произведение матриц:");
PrintArray(FindMult(matrix1,matrix2));

///////////////////////////////////////////////////////////
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

int[,] FindMult(int[,]array1, int[,]array2)
{
    int[,]array = new int[array1.GetLength(0),array2.GetLength(1)];
    for (int i=0; i<array1.GetLength(0); i++)
    {
        for (int j=0; j<array2.GetLength(1); j++)
        {
            for(int a=0; a<array1.GetLength(1); a++)
            {
                array[i,j]+=array1[i,a]*array2[a,j];
            }
        }
    }
    return array;
}