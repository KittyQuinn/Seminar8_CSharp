// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.


Console.WriteLine("Type the number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type the number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());

if (rows != columns)
{
    Console.WriteLine("Please type the same numbers for rows and columns ");
    return;
}


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
        }
        Console.WriteLine();
    }
}

int [,] ChangeArray(int[,] array)
{
    int[,] result = new int [array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[j,i] = array[i,j];
        }
       
    }

    return result;
}

int[,] array2 = GetArray(rows,columns,2,9);


PrintArray(array2);
Console.WriteLine("__________________");

PrintArray(ChangeArray(array2));