// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

Console.Clear();

// int[,] matr = new int [3,4];

// for (int i = 0; i < matr.GetLength(0); i++)
// {
//     for (int  j= 0; j < matr.GetLength(1); j++)
//     {
//         matr[i,j] = new Random().Next(11);
//         Console.Write(matr[i,j]+"\t");
//     }
//     Console.WriteLine();
// }


Console.WriteLine("Type the number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type the number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(min,max+1);
        }
    }
    return result;
}

void ChangeRows(int[,] matrix)
{
    int rowsCount = matrix.GetLength(0)-1;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0,i];
        matrix[0,i] = matrix[rowsCount,i];
        matrix[rowsCount,i] = temp;
    }
}

void PrintArray(int [,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j]);
        }
        Console.WriteLine();
    }
}

int[,] array = GetArray(rows,columns,2,9);


PrintArray(array);

Console.WriteLine("__________________");

ChangeRows(array);
PrintArray(array);