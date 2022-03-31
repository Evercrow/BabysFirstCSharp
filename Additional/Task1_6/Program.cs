Console.Clear();
// Console.WriteLine("________________________________________________________");
// Console.WriteLine("Знакомство с языками программирования. Семинар 6. Дополнительные задачи.");
// Console.WriteLine("Задача 1. Написать перевод десятичного числа в двоичное, используя рекурсию.");
// Console.WriteLine("________________________________________________________");
// Console.WriteLine();

/*
Console.Write("Enter decimal number: ");
int numberDec = Convert.ToInt32(Console.ReadLine());

string numberBin = "";
convertingToBin(numberDec, numberBin); Console.WriteLine();


static void convertingToBin(int num, string snum)
{

    if (num % 2 == 0) snum = "0" + snum;
    else snum = "1" + snum;
    if (num / 2 == 0)
    {
        Console.Write("Binary number: " + snum);
        return;
    }
    convertingToBin(num / 2, snum);
}

*/

Console.Write("Введите десятичное число: "); 
int numberDec = Convert.ToInt32(Console.ReadLine());

string numberBin = "";
numberBin = convertingToBin(numberDec, numberBin); Console.WriteLine();
Console.Write("Двоичное число: " + numberBin); 

static string convertingToBin(int num, string snum)
{   
    if (num % 2 == 0) snum = "0" + snum;
    else snum = "1" + snum;
   
    if ((num/2) != 0) return convertingToBin(num/2, snum); 
    else return snum;
}