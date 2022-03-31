// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.



int[,] GetRandomArray(int rows, int columns)
{
    int[,] result_array = new int[rows, columns];
    for (int i = 0; i < result_array.GetLength(0); i++)
    {
        for (int j = 0; j < result_array.GetLength(1); j++)
        {
            result_array[i, j] = new Random().Next(1,10);
            Console.Write(result_array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
    return result_array;
}



int[,] SquaredEvenIndexArray(int [,] even_array)
{
    for (int i = 0; i < even_array.GetLength(0); i=+2)
    {
        for (int j = 0; j < even_array.GetLength(1); j=+2)
        {
            even_array [i, j] = even_array[i, j] * even_array[i, j];
        }
        
    }
    return even_array;
}

void Task3FullArray(int rows,int columns)
{
    int[,] result_array = new int[rows, columns];
    for (int i = 0; i < result_array.GetLength(0); i++)
    {
        for (int j = 0; j < result_array.GetLength(1); j++)
        {
            result_array[i, j] = new Random().Next(1,10);
            Console.Write(result_array[i, j] + " ");
            if (i % 2 == 0 && j % 2 == 0) result_array[i, j]=result_array[i, j] * result_array[i, j];
        }
        Console.WriteLine(" ");
    }

    Console.WriteLine("-------------------");



    for (int i = 0; i < result_array.GetLength(0); i++)
    {
        for (int j = 0; j < result_array.GetLength(1); j++)
        {
            Console.Write(result_array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}


Console.WriteLine("Enter how many rows there will be in array, size m:");
int m =Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter how many columns there will be in array, size n:");
int n = Convert.ToInt16(Console.ReadLine());

Task3FullArray(m,n);


// int [,] user_array = GetRandomArray(m,n);
// SquaredEvenIndexArray(user_array);
// PrintArray(user_array);

// PrintArray(SquaredEvenIndexArray(GetRandomArray(m,n)))
