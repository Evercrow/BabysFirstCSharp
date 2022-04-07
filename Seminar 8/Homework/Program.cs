// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void PrintMatrix(int[,] printed_matrix)
{
    for (int i = 0; i < printed_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < printed_matrix.GetLength(1); j++) Console.Write(printed_matrix[i, j] + " ");
        Console.WriteLine(" ");
    }
    Console.WriteLine("---------------");
}


int[,] GetRandomArray(int range)
{
    Console.WriteLine("How many rows?");
    int rows = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("How many columns?");
    int columns = Convert.ToInt16(Console.ReadLine());


    int[,] result_array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result_array[i, j] = new Random().Next(range);
        }
    }
    return result_array;
}


int[,] SortDescendingArray(int[,] sortedArray)
{

    for (int i = 0; i < sortedArray.GetLength(0); i++)
    {
        int sortedSize = 0;
        while (sortedSize < sortedArray.GetLength(1) - 1) // перебор пар до максимального числа перестановок(когда максимум справа изначально)   
        {
            for (int j = 0; j < sortedArray.GetLength(1) - 1; j++)
            {
                if (sortedArray[i, j] < sortedArray[i, j + 1])
                {
                    int swap = sortedArray[i, j];
                    sortedArray[i, j] = sortedArray[i, j + 1];
                    sortedArray[i, j + 1] = swap;
                }
            }
            sortedSize++;
        }

    }
    return sortedArray;
}



// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FindMinimalRow(int[,] array)
{
    int minSum = int.MaxValue;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];

        }
        Console.WriteLine($"row {i + 1}: {sum}");
        if (sum < minSum)
        {
            minSum = sum;
            result = i;
        }
    }
    Console.WriteLine($"The row with minimal sum of numbers is #{result + 1}.");
}


// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 75(0,1,0) 31(0,1,1)
// 45(1,0,0) 53(1,0,1)
// 32(1,1,0) 23(1,1,1)


int[,,] Unique3DArray(int size)
{
    int elems = 1;
    Random rnd = new Random();
    int multiplier = rnd.Next(5, 10);
    Console.WriteLine("random seed is " +multiplier);
    Console.WriteLine();
    int[,,] array3D = new int[size, size, size];
    for (int i = 0; i < size; i++)
    {
        for (int col = 0; col < size; col++)
        {
            for (int depth = 0; depth < size; depth++)
            {
                array3D[i, col, depth] = multiplier + multiplier * elems;
                elems++;
            }
        }
    }
    return array3D;
}

void Print3DArray(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            for (int depth = 0; depth < array.GetLength(2); depth++)
            {
                Console.Write(array[i, col, depth] + $"({i},{col},{depth}) ");
            }
            Console.WriteLine("");
        }
    }
}



// Задача 4: Заполните спирально массив 4 на 4.

// На выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] FillSpiralArray(int[,] array)
{

    if (array.GetLength(0) == array.GetLength(1) && array.GetLength(0) != 1)
    {
        int filler = 1;
        int coil_num = 0;
        while (array.GetLength(0)-coil_num>1) FillSpiralBorders(array,ref coil_num,ref filler);
        return array;
    }
    else
    {
        Console.WriteLine("Cannot fill this array.");
        return array;
    }

}


int[,] FillSpiralBorders(int[,] bordArray,ref int coil_num,ref int filler)
{
    for (int i = coil_num; i < bordArray.GetLength(1)-coil_num; i++)
    {
        bordArray[coil_num,i] = filler;
        filler++;
    }
    for (int i = 1 + coil_num; i < bordArray.GetLength(0)-coil_num; i++)
    {
        bordArray[i,bordArray.GetLength(1)-1-coil_num] = filler;
        filler++;
    }
    for (int i = bordArray.GetLength(1)-2-coil_num; i > coil_num; i--)
    {
        bordArray[bordArray.GetLength(0)-1-coil_num,i] = filler;
        filler++;
    }
    for (int i = bordArray.GetLength(0)-1-coil_num; i > coil_num; i--)
    {
        bordArray[i,coil_num] = filler;
        filler++;
    }
    coil_num++;
    return bordArray;

}



//Function calls

Console.Clear();
Console.WriteLine("Task 1 : sorting random array");
int[,] task1Array = GetRandomArray(100);
PrintMatrix(task1Array);
SortDescendingArray(task1Array);
PrintMatrix(task1Array);
Console.WriteLine();

Console.WriteLine("Task 2 : finding minimal row");
int[,] task2Array = GetRandomArray(10);
PrintMatrix(task2Array);
FindMinimalRow(task2Array);
Console.WriteLine();

Console.WriteLine("Task 3 : creating 3D array");
Print3DArray(Unique3DArray(2));
Console.WriteLine();

Console.WriteLine("Task 4 :");
Console.WriteLine("You can adjust spiral size(default =4): ");
int size = Convert.ToInt16(Console.ReadLine());
int[,] spiral = new int[size, size];
PrintMatrix(FillSpiralArray(spiral));




