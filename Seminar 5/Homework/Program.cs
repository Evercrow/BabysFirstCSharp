// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
/*

int[] Get3DigitNatArray(int array_size)
{
    int[] num_array=new int[array_size];
    for(int i=0;i<array_size; i++)
        {
        num_array[i]=new Random().Next(100,1000);
        Console.Write("["+num_array[i]+"] ");
        }
    Console.WriteLine("");        
    return  num_array; 
}


Console.WriteLine("Enter the size of new random array: ");
int user_size = Convert.ToInt16(Console.ReadLine());
int[] user_array=Get3DigitNatArray(user_size);
int count=0;

for (int i=0;i<user_size; i++)
{
    if (user_array[i]%2 == 0) count++;
}

Console.WriteLine($"There are {count} even numbers in this array.");

*/





// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


/*
int[] GetNewIntArray()
{
    Console.WriteLine("Enter the size of new random array: ");
    int array_size = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Enter lower border of  array's range: ");
    int user_range_low = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter lower border of  array's range: ");
    int user_range_up = Convert.ToInt32(Console.ReadLine());
    int[] num_array=new int[array_size];
    for(int i=0;i<array_size; i++)
        {
        num_array[i]=new Random().Next(user_range_low,user_range_up);
        Console.Write("["+num_array[i]+"] ");
        }
    Console.WriteLine("");        
    return  num_array; 
}



int[] user_array=GetNewIntArray();
int sum=0;

for (int i=0; i<user_array.Length; i+=2 ) sum+=user_array[i];
Console.WriteLine("The sum of elements with odd indexes is "+sum+".");

*/





// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] GetNewDoubleArray()
{
    Console.WriteLine("Enter the size of new random array: ");
    int array_size = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Enter lower border of  array's range: ");
    int user_range_low = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter upper border of  array's range: ");
    int user_range_up = Convert.ToInt32(Console.ReadLine());
    double[] num_array=new double[array_size];
    for(int i=0;i<array_size; i++)
        {
        num_array[i]=new Random().NextDouble()*(new Random().Next(user_range_low,user_range_up));  //основная сложность задачи была как раз здесь. Почитать пришлось про NextDouble, и поиграться с записью из-за ругани компилятора :)
        Console.Write("["+num_array[i]+"] ");
        }
    Console.WriteLine("");        
    return  num_array; 
}

double[] user_array=GetNewDoubleArray();
double max= double.MinValue,min=double.MaxValue;
foreach (double number in user_array)
{
    if (number > max) max=number;
    if (number < min) min=number;    
}
Console.WriteLine("The difference between max and min number is "+(max-min)+".");
