// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


// Показать треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника.

int[,] CreatePascalTriangle(int size)
{
    int[,] triangle = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < size; i++)
    {
        for (int j = 1; j < i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
    PrintMatrix(triangle);
    return triangle;

}

void PrintMatrix(int[,] printed_matrix)
{
    for (int i = 0; i < printed_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < printed_matrix.GetLength(1); j++) Console.Write(printed_matrix[i, j] + " ");
        Console.WriteLine(" ");
    }
}




DisplayPascalTriangle(CreatePascalTriangle(10));

void DisplayPascalTriangle(int[,] pasc)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine(tri);
    for (int i = 0; i < pasc.GetLength(0); i++)
    {
        int cursor_position = (pasc.GetLength(1) / 2 + pasc.GetLength(1) % 2) * 2 - i;
        if (pasc.GetLength(1) > 5 && i < 5)  Console.Write(" ");
        if (pasc.GetLength(1) >= 10 && i < 10)  Console.Write(" ");
        for (int k = 0; k < cursor_position; k++)
        {
            
            Console.Write(" ");
        }
        for (int j = 0; j < pasc.GetLength(1); j++)
        {
            
            if (pasc[i, j] != 0) Console.Write(pasc[i, j] + " ");
            
        }
        
        Console.WriteLine(" ");
    }
}
