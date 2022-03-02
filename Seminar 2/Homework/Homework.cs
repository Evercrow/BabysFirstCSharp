/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*
Console.WriteLine("Enter your 3-part number:"); //подчеркивает Console как ошибку про top-level statements ,(так как это у меня подпапка проекта со второго семинара), но компилируется у меня нормально.
int num = Convert.ToInt32(Console.ReadLine());

//соскучился по циклу while решил его в интерфейс добавить :)
while (Math.Abs(num) >= 1000)  //заодно погуглил как взять модуль числа, нашел только через вызов метода Math. Я так понял, у англичан absolute value и переводится как наш "модуль числа"? А Modulus ищет остаток от деления. Жду ваших ответов в оценке домашки, Павел :)
{
Console.WriteLine("Entered number is not 3-part, please, try again: ");
num = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(ShowSecondPart(num));

int ShowSecondPart(int number)
{
   return ((Math.Abs(number%100)/10));
}
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/


/*
//интересно как эту программу написать, не используя свойства string как массива? Разве что по одной цифре из консоли в числовой массив записывать.

Console.WriteLine("Enter your number:"); 
string num = Console.ReadLine();        
//Консоль ругается, что можно получить exception, если в readline подадут null значение. Как это обойти? Есть convert какой-нибудь только для null? 

if (num.Length<3) Console.WriteLine("There is no 3rd part");
else Console.WriteLine(num[2]);
*/



/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Enter your day number:"); 
int day = Convert.ToInt16(Console.ReadLine());

if ((day < 1) || (day>7))
   Console.WriteLine("Day with such number does not exist. Switch to gregorian calendar, mate!"); 
else
    {
    if(day > 5)
    Console.WriteLine("Yes, it is, indeed, weekend.");
    else
    Console.WriteLine("No, it's your normal weekday.");
    }
