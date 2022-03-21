// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int ArythmSum(int A)
{
    int result = 0;

    int i = 1;
    while (i <= A)
    {
        result = result + i;
        i++;
    }
    return result;
}

Console.WriteLine("Введите ваше целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA < 1) Console.WriteLine("Вы ввели ненатуральное число");
else Console.WriteLine($"Cумма чисел от 1 до {numA} равна {ArythmSum(numA)}");
*/

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Factorial(int N)
{
    int result = 1;
    for ( int i = 1;i <= N;i++) result = result*i;
    return result;
}

Console.WriteLine("Введите ваше целое число: ");
int numN = Convert.ToInt32(Console.ReadLine());
if (numN < 1) Console.WriteLine("Вы ввели ненатуральное число");
else Console.WriteLine($"Произведение чисел от 1 до {numN} равна {Factorial(numN)}");




// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
