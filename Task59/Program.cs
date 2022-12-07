// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен 
// наименьший элемент массива.

Console.Clear();

Console.WriteLine("Type the number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type the number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());

int minValue = int.MaxValue;
int minIndexRows = 0;
int minIndexCol = 0;

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

void PrintArray(int [,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j]);
            if (minValue>inputArray[i,j])
            {
                minValue = inputArray[i,j];
                minIndexRows = i;
                minIndexCol = j;
            }
        }
        Console.WriteLine();
    }
}

int [,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i!=minIndexRows )
        {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j!=minIndexCol)
            {
                Console.Write(array[i,j]);
            }
        }
       
    }
    Console.WriteLine();
    }
    return array;
}

int[,] array2 = GetArray(rows,columns,2,9);


PrintArray(array2);
Console.WriteLine("__________________");

PrintArray(ChangeArray(array2));