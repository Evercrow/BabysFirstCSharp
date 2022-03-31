// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

/*
void PrintRandomArray(int rows, int columns)
{
    int[,] result_array = new int[rows, columns];
    for (int i = 0; i < result_array.GetLength(0); i++)
    {
        for (int j = 0; j < result_array.GetLength(1); j++)
        {
            result_array[i, j] = new Random().Next(100);
            Console.Write(result_array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}

Console.WriteLine("Enter how many rows there will be in array, size m:");
int m =Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter how many columns there will be in array, size n:");
int n = Convert.ToInt16(Console.ReadLine());
PrintRandomArray(m,n); 
*/

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.


/*
int[,] GetSizeSumArray(int rows, int columns)
{
    int[,] result_array = new int[rows, columns];
    for (int i = 0; i < result_array.GetLength(0); i++)
    {
        for (int j = 0; j < result_array.GetLength(1); j++)
        {
            result_array[i, j] = (i+1)+(j+1);
            Console.Write(result_array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
    return result_array;
}

Console.WriteLine("Enter how many rows there will be in array, size m:");
int m =Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter how many columns there will be in array, size n:");
int n = Convert.ToInt16(Console.ReadLine());
int[,] indexSumArray = GetSizeSumArray(m,n);

*/

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
    for (int i = 0; i < even_array.GetLength(0); i+=2)
    {
        for (int j = 0; j < even_array.GetLength(1); j+=2)
        {
            even_array [i, j] = even_array[i, j] * even_array[i, j];
        }
        
    }
    return even_array;
}

void PrintArray(int[,] printed_array)
{
    Console.WriteLine("-------------------");
    for (int i = 0; i < printed_array.GetLength(0); i++)
    {
        for (int j = 0; j < printed_array.GetLength(1); j++)
        {
            Console.Write(printed_array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}


void Task3AllInOneArray(int rows,int columns)
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
PrintArray(SquaredEvenIndexArray(GetRandomArray(m,n)));
                                                                           
//Task3AllInOneArray(m,n);    //здесь все работает без проблем, то есть проблема именно в шагании через...и тут до меня дошло 
                               // я шагал с записью =+2  , а надо +=2  . Особенности языка выстрелили в ногу :D




// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

/*
int FindDiagonalSum(int size)
{
    int[,] result_array = new int[size, size];
    int sum_diag = 0;
    for (int i = 0; i < result_array.GetLength(0); i++)
    {
        for (int j = 0; j < result_array.GetLength(1); j++)
        {
            result_array[i, j] = new Random().Next(10);
            if ( i == j) sum_diag+=result_array[i, j];
            Console.Write(result_array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
    return sum_diag;
}

Console.WriteLine("Enter size of your array:");
int m =Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"The sum of diagonal elements is {FindDiagonalSum(m)}");

*/
