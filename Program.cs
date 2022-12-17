// Задайте две матрицы.
//Напишите программу , которая будет находить
//произведение двух матриц.

Console.Write("Введите количество строк массива A : ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива A : ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк массива B: ");
int rows1 = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива B: ");
int columns1 = int.Parse(Console.ReadLine());
if ( rows != columns1) 
{
    Console.WriteLine(" Умножение матриц невозможно :");
    goto Found;
}
else
Console.WriteLine();




int[,] result =GetArrayMatrix (rows, columns, -10, 10);
Console.WriteLine(" Исходная матрица А :");
PrintArray(result);
Console.WriteLine();

int[,] result1 =GetArrayMatrix (rows1, columns1, -10, 10);
Console.WriteLine(" Исходная матрица B :");
PrintArray(result1);




int[,] resMultip = new int[columns, rows1];


 
    {
            
           for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns1; j++)
                    for (int k = 0; k <columns1; k++)
                        resMultip[i, j] += result[i, k]*result1[k, j];
                        Console.WriteLine(" Результат умножения матриц А и B :");
         PrintArray( resMultip);
    }

      



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
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}  ");
        }
        Console.WriteLine();
    }
}

Found:
Console.WriteLine(" The END ");