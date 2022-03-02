/* int number = new Random().Next(10,99);
Console.WriteLine("Current number is "+number+" and it's max part is " + ShowMaxNumber(number));

int ShowMaxNumber(int number)
{
    int singles = number%10 ;
    int tens = number/10 ;

    if (tens>singles) 
    return tens;
    else 
    return singles;
}
*/


//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.//

/*
int number = new Random().Next(100,1000);
Console.WriteLine("Current number is "+number+" and the transformed number is " + RemoveSecondPart(number));

int RemoveSecondPart(int number)
{
   int singles = number%10 ;
   int hundreds = number/100;
   return (hundreds*10+singles);
}
*/

/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число не кратно числу первому, то программа выводит остаток от деление.

Console.WriteLine("Enter first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The remainder of division of two entered numbers equals "+ CheckRemainder(num1,num2));
*/
/*
int CheckRemainder(int num1, int num2)
{
    int dividend,divisor,result;
    if (num1> num2){
    dividend = num1;
    divisor = num2;
    }
    else {
    dividend = num2;
    divisor = num1;
    }

    result = dividend%divisor;

    if (result == 0)
    Console.WriteLine(dividend+" is divisible by "+ divisor); 
    return result;
}
*/
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно двум введенным пользователем числам.
Console.WriteLine("Enter number we are checking:");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter first divisor number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second divisor number:");
int num2 = Convert.ToInt32(Console.ReadLine());

DivisionCheck(num3,num1,num2);

void DivisionCheck(int dividend, int divisor1, int divisor2)
{
    if (dividend%divisor1 == 0 && dividend%divisor2 == 0)
       Console.WriteLine(dividend+" is divisible by both divisor numbers");
       else 
        {
            if  (dividend%divisor1 == 0)
                Console.WriteLine(dividend+" is divisible by "+divisor1);
            else
            {
                if (dividend%divisor2 == 0)
                Console.WriteLine(dividend+" is divisible by "+divisor2);
                else
                Console.WriteLine(dividend+" is not divisible by "+divisor1+" or "+divisor2);
            }   
        }        
}
