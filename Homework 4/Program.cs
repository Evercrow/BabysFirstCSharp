/* Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
double CheckPowers(int A , int B)
{
    double result = Math.Pow(A,B);
    return result;
}

Console.WriteLine("To end program , submit empty space or any string instead of numbers.");
Console.WriteLine("---------------");
Console.WriteLine("Enter base number first and then power(exponent) number separately :");
PowerTable();
// Зацепился за слово "цикл" в условии задачи, и написал метод, который будет считать степени пока ему строку не подадут на вход. 
// Откопал TryParse, вроде работает. Хотя консоль все равно ругается желтым, что converting null literal to non-nullable type.  
void PowerTable()
{
    while (true)
    {
    string base_str = Console.ReadLine();
    bool exit1 = Int32.TryParse(base_str, out int base_num);
    if (exit1 == false) break;
    // Теперь обыгрываем слова "натуральная степень" в условии. В данном случае циклы на ReadLine сажать как-то некорректно, поэтому попробовал goto .
    NaturalPower:
        string power_str = Console.ReadLine();
        bool exit2 = Int32.TryParse(power_str, out int power_num);
        if (exit2 == false) break;
        if (power_num<1)
        {
            Console.Write("The power number must be natural number , try again: "); 
            goto NaturalPower;
        } 
    Console.WriteLine($"{base_num} raised to the power of {power_num} equals {CheckPowers(base_num, power_num)}");
    }
    Console.WriteLine("Program has ended by user's input");
}
//Насколько громоздко вышло? 
*/


//Цикл "ручного" возведения в степень

double AltPower(int A, int B)
{
    double result=1;
    for (int i = 0; i<B; i++)
    {
        result *=A;
    }
    return result;
}

Console.WriteLine("Enter number that is going to be base:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number that is going to be power:");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2<1) Console.WriteLine("power number must be natural(greater than 0)");
else Console.WriteLine($"{num1} to the power of {num2} equals {AltPower(num1,num2)}");









/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

/*
int DigitSum(int input)
{
    int result = 0;
    input=Math.Abs(input);
    while(input>0)
    {
        result=result+input%10;
        input=input/10;
    }
    return result;
}

Console.WriteLine("Enter your number: ");
int number=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum of digits is "+DigitSum(number));
*/


/*
Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/*
Console.WriteLine("How many numbers you need to store in array?");
int size = Convert.ToInt16(Console.ReadLine());
int[] my_numbers = ArrayWrite(size);
Console.WriteLine("Your numbers are stored in array called 'my_numbers', here are it's contents: ");
Console.Write("[ ");
foreach (int i in my_numbers) Console.Write(i+" ");
//понял разницу между for и foreach. Здесь в i сразу присваиваются элементы массива, а индекс прогоняется за кадром.
Console.Write("]");


int[] ArrayWrite(int a_size)
{       
    int[] stored_nums = new int[a_size];
    for (int i=0; i<=stored_nums.Length-1; i++) stored_nums[i]=Convert.ToInt32(Console.ReadLine());
    return stored_nums;
}
*/