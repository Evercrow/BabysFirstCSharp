/*Пользователь вводит целые числа до тех пор, пока не введёт ноль. 
Вывести на экран первые два максимальных и первые два минимальных числа из ряда введенных чисел.
 А теперь самое интересное: создавать массивы в процессе решения запрещено 
  1 2 3 4 5 6 0 -> максимальные  5 и 6, минимальные 1 и 2.
  3, 3, -3 0-> максимальные 3, 3; минимальные 3, -3
  5 2 -3 17 -5 4 0 ->5 и 17 - макс, -5 и -3 - мин.  
 */

int max1 = int.MinValue, max2 = int.MinValue, min1 = int.MaxValue, min2 = int.MaxValue;
int input, n = 0;
Console.WriteLine("Enter your numbers individually, the program will finish after you enter 0:");
while (true)
{
    input = Convert.ToInt32(Console.ReadLine());
    if (input == 0) break;
    n++;
    if (n == 1)
    {
        max1 = input;
        min1 = input;
    }
    else
    {
        if (input >= max1)
        {
            max2 = max1;
            max1 = input;
        }
        else if (input >= max2) max2 = input;

        if (input <= min1)
        {
            min2 = min1;
            min1 = input;
        }
        else if (input <= min2) min2 = input;
    }
}

if (n <= 2) Console.WriteLine($"Highest number is {max1} , lowest numbers is {min1}");
else Console.WriteLine($"Highest numbers are {max1} and {max2}, lowest numbers are {min1} and {min2}");
// else Console.WriteLine($"Highest numbers are {max1} and {max2}, lowest numbers are {min1} and {min2}. One of the min-max value shown is default,as there is not enough numbers entered for all comparison pairs");