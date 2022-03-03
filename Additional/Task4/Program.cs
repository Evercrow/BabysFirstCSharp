// Задача 4. Дано натуральное число, в котором все цифры различны. 
//Определить, какая цифра расположена в нем левее: максимальная или минимальная.

/*
int number = 701234589;

 LeftmostMinMax(number);

void LeftmostMinMax(int number){
   int i = 0;
   int index_max = 0 , index_min = 0;
   char max, min;
   string holder = Convert.ToString(number);
   max = holder[i];
   min = holder[i];

   while (i < holder.Length-1){

      if (holder[i+1] > max)
      {
         max = holder [i+1];
         index_max = i+1;
      }
      else if(holder[i+1] < min)
      {
         min = holder [i+1];
         index_min = i+1;
      }
      i++;
   }

   if (index_min > index_max)
    {
        Console.WriteLine("max number is leftmost");
    }
    else
    {
        Console.WriteLine("min number is leftmost");
    }
   */



// Задача 2. На вход подаются год, номер месяца и день рождения человека, 
// Определить возраст человека на момент 1 февраля 2022 года.
Console.WriteLine("Enter you birthday: ");
int b_day = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter your birth month: ");
int b_month = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter your birth year: ");
int b_year = Convert.ToInt16(Console.ReadLine());

void HowOld(int b_day, int b_month, int b_year)
{

    if (b_month > 2)
    {
        Console.WriteLine("Your age is " + (2022 - b_year - 1));
    }

    if (b_month == 2)
    {
        if (b_day == 1)
        {
            Console.WriteLine("Your age is " + (2022 - b_year));
        }
        else Console.WriteLine("Your age is " + (2022 - b_year - 1));
    }
    else
        Console.WriteLine("Your age is " + (2022 - b_year));

}


HowOld(b_day, b_month, b_year);



