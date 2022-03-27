// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

/*
int[] num_array=new int[12];
int pos=0,neg=0;
for(int i=0;i<12; i++) 
{
int number=new Random().Next(-9,10);
if (number>=0) pos+=number;
else neg+=number;
Console.Write("["+number+"] ");
}
Console.WriteLine("");
Console.WriteLine("Sum of positive elements is "+pos+" ,sum of negative elements is "+neg+" .");
*/



//Напишите программу замена элементов массива:
//положительные элементы замените на соответствующие отрицательные, и наоборот.

/*
int[] num_array=new int[12];
for(int i=0;i<num_array.Length; i++)
{
num_array[i]=new Random().Next(-9,10);
Console.Write("["+num_array[i]+"] ");
num_array[i]=-num_array[i];
}
Console.WriteLine("");
Console.WriteLine("And the opposite array looks like this:");
foreach (int read in num_array) Console.Write("["+read+"] ");
*/



//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. Yes, No

/*
Console.WriteLine("Enter the size of new random array: ");
int array_size = Convert.ToInt16(Console.ReadLine());
int[] num_array=new int[array_size];
Console.WriteLine("Enter the range of your array: ");
int array_range = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter number you want to check(possible existing numbers are from 0 to "+array_range+"): ");
int check_num = Convert.ToInt16(Console.ReadLine());
bool check=false;
for(int i=0;i<array_size; i++)
{
    num_array[i]=new Random().Next(array_range);
    Console.Write("["+num_array[i]+"] ");
    if (num_array[i] == check_num) 
    {
        check = true;
        Console.WriteLine("");
        Console.Write("Yes, "+check_num+" is found in this array.");
        break;
    }
}
Console.WriteLine("");
if (check == false) Console.Write("No, "+check_num+" is not found in this array.");
*/
//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
/*
int[] num_array=new int[123];
Console.WriteLine("Enter the range of your array: ");
int array_range = Convert.ToInt16(Console.ReadLine());
int count=0;
for(int i=0;i<123; i++)
{
num_array[i]=new Random().Next(array_range);
Console.Write("["+num_array[i]+"] ");
if (num_array[i] <100 && num_array[i]>9) count++;
}
Console.WriteLine("");
Console.Write("There are "+count+" that fit in range of [10,99] in this array.");
*/


//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] GetNewNatArray(int array_size,int array_range)
{
    int[] num_array=new int[array_size];
    for(int i=0;i<array_size; i++)
        {
        num_array[i]=new Random().Next(array_range);
        Console.Write("["+num_array[i]+"] ");
        }
    Console.WriteLine("");        
    return  num_array; 
}

Console.WriteLine("Enter the size of new random array: ");
int user_size = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the range of new random array: ");
int user_range = Convert.ToInt16(Console.ReadLine());
int[] user_array=GetNewNatArray(user_size,user_range);
int[] mult_array= new int[user_size/2+1]; 
Console.WriteLine("The multiplication pairs for created array are these: ");
for(int i=0;i<(user_size/2); i++)
{
    mult_array[i]=user_array[i]*user_array[user_size-1-i];
    Console.Write("["+ mult_array[i]+"] ");
}
if ((user_size%2)!=0) 
{
    mult_array[user_size/2]=user_array[user_size/2];
    Console.WriteLine($"[{mult_array[user_size/2]}] ");
}    
