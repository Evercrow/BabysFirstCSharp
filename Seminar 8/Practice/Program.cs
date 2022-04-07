

void PrintMatrix(int[,] printed_matrix)
{
    for (int i = 0; i < printed_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < printed_matrix.GetLength(1); j++) Console.Write(printed_matrix[i, j] + " ");
        Console.WriteLine(" ");
    }
    Console.WriteLine("---------------");
}




//Function calls


