// Задача 1:
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, 
// k1 = 5, 
// b2 = 4, 
// k2 = 9 -> (0,5; 4,5)

// string CrossPoint (double b1, double k1, double b2, double k2)
// {
//     double xCross = (double)(b1-b2)/(k1-k2);
//     double yPeres = k1 * xCross + b1;
//     string result = "" + xCross + ";" + yPeres;
//     return result;
// }

// Console.WriteLine("Введите b1: ");
// int bLine1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k1: ");
// int kLine1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b2: ");
// int bLine2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k2: ");
// int kLine2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{Peresechenie (bLine1, kLine1, bLine2, kLine2)}");



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
    // PrintMatrix(triangle);
    return triangle;

}

// void PrintMatrix(int[,] printed_matrix)
// {
//     for (int i = 0; i < printed_matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < printed_matrix.GetLength(1); j++) Console.Write(printed_matrix[i, j] + " ");
//         Console.WriteLine(" ");
//     }
// }






void DisplayPascalTriangle(int[,] pasc)
{
    Console.WriteLine("-----------------------");
    int height = pasc.GetLength(0);
    string[] line_chars = new string[height];
    int base_chars = 0;
    for (int j = 0; j < pasc.GetLength(0); j++)
    {

        for (int i = 0; i < pasc.GetLength(1); i++)
        {
            if (pasc[pasc.GetLength(1) - 1 - j, i] != 0) line_chars[height - 1 - j] += pasc[pasc.GetLength(1) - 1 - j, i]+" ";
        }
        // Console.WriteLine($"{height - 1 - j} line is {line_chars[height - 1 - j].Length} long");
        base_chars = line_chars[height-1].Length;
        // shift = shift.PadLeft(Math.Abs(line_chars[height - 1 - j].Length - base_chars) / pasc.GetLength(1));
    }
    Console.Clear();
    Console.SetWindowSize(base_chars+2, height+2);
    Console.SetBufferSize(base_chars+2, height+2);
    for (int i = 0; i < height; i++)
    {
        // int cursor_position = (pasc.GetLength(1) / 2 + pasc.GetLength(1) % 2) * 2 - i;
        // for (int k = 0; k < cursor_position; k++)
        // {
        //     Console.Write(" ");
        // }
        // line_chars[i]=line_chars[i].PadLeft(base_chars/2);
        Console.SetCursorPosition(base_chars/2-line_chars[i].Length/2, i);
        Console.WriteLine(line_chars[i]);
    }
}
Console.WriteLine("What height of Pascal triangle you need?");
Console.WriteLine("(standart screen size can show 21 max properly)");
int userSize = Convert.ToInt32(Console.ReadLine());
DisplayPascalTriangle(CreatePascalTriangle(userSize));


