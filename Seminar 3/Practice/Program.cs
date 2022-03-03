/*
Написать программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

/*
int PointQuarter(double xPoint, double yPoint)
{
    if (xPoint > 0 && yPoint >0 ) return 1;
    if (xPoint < 0 && yPoint >0 ) return 2;
    if (xPoint < 0 && yPoint <0 ) return 3;
    if (xPoint > 0 && yPoint <0 ) return 4;
    return 0;
}


double x,y; // - с double  не работают целочисленные операторы нахождения отстатка, нужно сначала преобразовать
Console.WriteLine("Enter X coordinate of the point: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Y coordinate of the point: ");
y = Convert.ToDouble(Console.ReadLine());
int quartNum = PointQuarter(x,y);
if (quartNum == 0) 
{
    Console.WriteLine("Quarter of your point is non-defined, as it's on the base coordinate lines");
}
else
Console.WriteLine("Quarter of your point is "+ PointQuarter(x,y));
*/

//Написать программу, которая принимает на вход номер четверти ивыводит на экран диапазон координат,
// доступных в этой четверти

/*
Console.WriteLine("Enter your coordinate quarter: ");
int quart = Convert.ToInt16(Console.ReadLine());
ShowCoord(quart);

void ShowCoord(int quartNum)
{
    if ( quartNum == 1) 
    Console.WriteLine("Possible coordinates of your quarter are x > 0 and y > 0");
    if ( quartNum == 2) 
    Console.WriteLine("Possible coordinates of your quarter are x < 0 and y > 0");
    if ( quartNum == 3) 
    Console.WriteLine("Possible coordinates of your quarter are x < 0 and y < 0");
    if ( quartNum == 4) 
    Console.WriteLine("Possible coordinates of your quarter are x > 0 and y < 0");

    Console.WriteLine("Entered number of your quarter is not correct");
}
*/

// Написать программу, принимающую на вход координаты двух точек и определяющую расстояние между ними
double x1,y1,x2,y2 ;
Console.WriteLine("Enter X coordinate of the first point: ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Y coordinate of the first point: ");
y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter X coordinate of the second point: ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Y coordinate of the second point: ");
y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The interval between two points is "+ FindInterval(x1,y1,x2,y2));

double FindInterval(double xCoord1,double yCoord1,double xCoord2,double yCoord2)
{   
 double result = Math.Sqrt((xCoord1-xCoord2)*(xCoord1-xCoord2) + (yCoord1-yCoord2)*(yCoord1-yCoord2));
 return result;
}
