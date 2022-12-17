// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите количество строк исходного массива : ");
int rows = int.Parse(Console.ReadLine());
int m = rows;
Console.Write("Введите количество столбцов исходного массива (столбцов должно быть больше, чем строк) : ");
int columns = int.Parse(Console.ReadLine());
int n = columns;
int[,]array = GetArrayMatrix(rows, columns, 0, 9);

Console.WriteLine();
Console.Write("Исходная матрица : ");
Console.WriteLine();
PrintArray(array);
Console.WriteLine();

PrintArray(array);


Console.WriteLine(MinSum);

int[,]GetArrayMatrix( int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i=0; i<m; i++)
    {
       for(int j=0; j<n; j++)
        {
           result[i,j]= new Random().Next(minValue, maxValue+1 );
        }
    }
    return result;
}

void PrintArray(int[,]inArray)
{
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            Console.Write($"{inArray[i,j]}  ");
        }
        Console.WriteLine();
    }
}

int MinSum (int[,] array)
{
    int minSum=int.MaxValue;
    for(int i=0; i<array.GetLength(0); i++)
    {
       int sum=0;
        for(int j=0; j<array.GetLength(1); j++)
        {
            sum+=array[i,j];
        }
         if (sum<minSum)
         minSum=sum;
    }
    return minSum;
} 






