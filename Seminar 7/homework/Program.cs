// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*
void PrintRandomDoubleArray(int rows, int columns)
{
    double[,] result_array = new double[rows, columns];
    for (int i = 0; i < result_array.GetLength(0); i++)
    {
        for (int j = 0; j < result_array.GetLength(1); j++)
        {
            result_array[i, j] = Math.Round(new Random().NextDouble() * 20 - 10 ,1, MidpointRounding.AwayFromZero);
            //почитал немного про задание NextDouble в диапазоне, и округление после запятой, 
            //привел максимально близко к образцовому массиву из условия.
            Console.Write("["+result_array[i, j] + "] ");
        }
        Console.WriteLine(" ");
    }
}

Console.WriteLine("Enter how many rows there will be in array, size m:");
int m =Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter how many columns there will be in array, size n:");
int n = Convert.ToInt16(Console.ReadLine());
PrintRandomDoubleArray(m,n); 
*/

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

/*
void LookupObjectInArray(int[,] lookup_array,int look_row,int look_col)
{
    if (look_row >lookup_array.GetLength(0) || look_col > lookup_array.GetLength(1)) 
    Console.WriteLine("Your specified position is out of array bounds.");
    else Console.WriteLine($"This object has value of {lookup_array[look_row,look_col]} .");

}

void PrintMatrix(int[,] printed_matrix)
{
    for (int i = 0; i < printed_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < printed_matrix.GetLength(1); j++) Console.Write(printed_matrix[i, j] + " ");
        Console.WriteLine(" ");
    }
}


int[,] init_array = new int[,] {{1,4,7,2},{5,9,2,3},{8,4,2,4}};
PrintMatrix(init_array);
Console.WriteLine("-------");
Console.WriteLine("Enter row number of required object:");
int user_row =Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter  column number of required object:");
int user_col = Convert.ToInt16(Console.ReadLine());
LookupObjectInArray(init_array,user_row,user_col); 
*/

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FindColumnArithmSum(int[,] summed_array)
{
    Console.Write("Arithmetic sum of each column is: ");

    for (int col = 0; col < summed_array.GetLength(1); col++)
    {
        decimal col_sum = 0;

        for (int row = 0; row < summed_array.GetLength(0); row++)
        {
            col_sum += summed_array[row, col];
        }
        col_sum /= summed_array.GetLength(0);

        if (col == summed_array.GetLength(1) - 1) Console.Write($"{col_sum.ToString("F")}.");
        else Console.Write($"{col_sum.ToString("F")}; ");

    }

}

void PrintMatrix(int[,] printed_matrix)
{
    for (int i = 0; i < printed_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < printed_matrix.GetLength(1); j++) Console.Write(printed_matrix[i, j] + " ");
        Console.WriteLine(" ");
    }
}


int[,] init_array = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
PrintMatrix(init_array);
Console.WriteLine("-------");
FindColumnArithmSum(init_array);

