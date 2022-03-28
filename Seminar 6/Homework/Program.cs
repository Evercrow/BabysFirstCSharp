// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
int CheckPositive(int end)
{
    int positives = 0;
    for (int i = 0; i < end; i++)
    {
        Console.Write($"{i + 1} number: ");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input > 0) positives++;
    }
    return positives;
}

Console.WriteLine("How many numbers you intend to check: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("There are " + CheckPositive(M) + " positive numbers.");
*/



// Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.

// 3, 4 ->
// 1 1 1 1
// 1 0 0 1
// 1 1 1 1



void PrintMatrix(int[,] printed_matrix)
{
    for (int i = 0; i < printed_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < printed_matrix.GetLength(1); j++) Console.Write(printed_matrix[i, j] + " ");
        Console.WriteLine(" ");
    }
}


int[,] FillBorder(int rows, int columns)
{
    int[,] border_matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        // сразу красим левую и правую границу
        border_matrix[i, 0] = 1;
        border_matrix[i, columns-1] = 1;
        Console.Write(border_matrix[i,0]+" "); // для вывода нужно не забыть первый и последний столбец. 
        for (int j = 1; j < columns - 1; j++) // исключаем левую и правую границы в условии цикла
        {
            border_matrix[0, j] = 1; // докрасили верхнюю и нижнюю
            border_matrix[rows-1, j] = 1;  
            // по умолчанию уже 0 подставлены в пустой integer массив, но попробуем все таки "заполнить" потом, как просят в условии.
            //border_matrix[i,j] = 0; Здесь снова 0ми станут левая и правая границы, поэтому без  if  мне не обойтись.
            Console.Write(border_matrix[i, j] + " ");
        }
        Console.WriteLine(border_matrix[i, columns - 1]+" ");
    }

    return border_matrix;
}

Console.Write("How many rows you need: ");
int user_rows = Convert.ToInt16(Console.ReadLine());
Console.Write("How many columns you need: ");
int user_columns = Convert.ToInt16(Console.ReadLine());

int [,] user_matrix = FillBorder(user_rows,user_columns); 
// PrintMatrix(user_matrix); -две функции очень пригодились для проверки того, что творится на самом деле с содержимым, когда бился над правильным выводом в консоль.


//Теперь попробуем сделать печать и заполнение внутри одной функции, не перекидывая массивы туда-сюда.


/*
void FillBorder(int rows, int columns)
{
    int[,] border_matrix = new int[rows, columns];

    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            if (j == 0 || j == rows - 1 || i == 0 || i == columns - 1)
            {
                border_matrix[j, i] = 1; // красим границы.
            }
            else border_matrix[j, i] = 0;
            Console.Write(border_matrix[j, i] + " ");
        }
        Console.WriteLine(" ");
    }

}


Console.Write("How many rows you need: ");
int user_rows = Convert.ToInt16(Console.ReadLine());
Console.Write("How many columns you need: ");
int user_columns = Convert.ToInt16(Console.ReadLine());
FillBorder(user_rows,user_columns);
*/

