// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
/*
void TriangleExist(int A, int B, int C)
{
    if (A > (B + C) ) Console.WriteLine("Triangle does not exist ");
    else if (B > (A + C)) Console.WriteLine("Triangle does not exist ");
    else if (C > (B + A)) Console.WriteLine("Triangle does not exist ");
    else Console.WriteLine("Triangle  exists ");
}


Console.WriteLine("Enter first number: ");
int side_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int side_B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number: ");
int side_C = Convert.ToInt32(Console.ReadLine());

TriangleExist(side_A,side_B,side_C);
*/

//Напишите программу, которая будет преобразовывать десятичное число в двоичное.

/*
string Transform(int number)
{
    string binary_num = ""; 
    while(number >= 1)
    {     
       binary_num = number%2+binary_num;
       number=number/2;
    }
    return binary_num;
} 

Console.Write("Enter decimal number:  ");
int user_input = Convert.ToInt32(Console.ReadLine());
Console.Write($"Binary number: ");
Console.WriteLine(Transform(user_input));
*/

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


/*
void Fib_Bruteforce(int size)
{
    int n1 = 0;
    int n2 = 1;
    int n;
    Console.Write(n1 + " " + n2 + " ");
    for (int i = 2; i < size; i++)
    {
        n = n1 + n2;
        n1 = n2;
        n2 = n;
        Console.Write(n + " ");

    }

}

Console.WriteLine("Enter  number:  ");
int N = Convert.ToInt32(Console.ReadLine());
Fib_Bruteforce(N);

*/

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int [,] init_array = new int[3,4];
for (int i=0; i<init_array.GetLength(0);i++)
{
    for (int j=0; j<init_array.GetLength(1);j++)
        {
            init_array[i,j]=new Random().Next(100);
            Console.Write(init_array[i,j]+" ");
        }
    Console.WriteLine(" ");        
}

