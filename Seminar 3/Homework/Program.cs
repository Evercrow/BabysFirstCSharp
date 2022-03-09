/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

/*
Console.WriteLine("Enter 5-digit number:");
string palindrom = Console.ReadLine();
while (palindrom.Length > 5) 
{
    Console.WriteLine("The number you entered is too long, please, try again:");
    palindrom = Console.ReadLine();
}
Check5Palindrom(palindrom);

void Check5Palindrom(string input)
{
  if (input[0]==input[4] && input[1]==input[3]) Console.WriteLine("Yes, the number you entered is a palindrom");
  else Console.WriteLine("No, the number you entered is not a palindrom");
}
*/

/*
//Также написал более общий случай по тому же принципу сравнения половинок. Есть ли более оптимальный вариант, например, через сортировку?
Console.WriteLine("Enter your string or number:");
string palindrom = Console.ReadLine();

CheckGenPalindrom(palindrom);

void CheckGenPalindrom(string input)
{
    int i,j = input.Length-1;
    bool pal_check = false;
    for (i=0; i <= (input.Length-1)/2 ;i++)
    {
        if (input[i]==input[j])
        {
            j--;
            pal_check = true;
        }
        else
        {
            pal_check = false;
            break;
        }       
    }
    if (pal_check == true) Console.WriteLine("Yes, the number or word you entered is a palindrom");
    else Console.WriteLine("No, the number or word you entered is not a palindrom");
}
*/



/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/







/*

Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
