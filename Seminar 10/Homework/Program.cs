// Задача: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
//В массиве data хранится информация о количестве бит, которые занимают числа из массива info.
//Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

// Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); 
// третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)

// Пример:

// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1  }
// info = {2, 3, 3, 1 }

// выходные данные:
// 1, 7, 0, 1


/*
int[] SplitBinToDec(int[] bin, int[] digitInfo)
{
    Console.Write("{ ");
    int[] result = new int[digitInfo.Length];
    int binPosition = 0;
    for (int pos = 0; pos < digitInfo.Length; pos++)
    {
        int number = 0;
        int pow = 0;
        for (int i=digitInfo[pos]-1; i>=0;i--)
        {
           number += bin[binPosition+i]*(int)Math.Pow(2,pow); 
           pow++;
        }
        Console.Write(number+" ");
        binPosition += digitInfo[pos];
        result[pos] = number;
    }
    Console.Write("}");
    return result;
}
*/

// Дорабатываем частные случаи


/*
int[] SplitBinToDec(int[] bin, int[] digitInfo)
{
    Console.Write("{ ");
    int[] result = new int[digitInfo.Length];
    int binPosition = 0;

    for (int pos = 0; pos < digitInfo.Length; pos++)
    {

        int number = 0;
        if (binPosition+digitInfo[pos] > bin.Length  )
        {
            int cut = digitInfo[pos] - bin.Length +binPosition;
            while(binPosition < bin.Length)
            {
                number += bin[binPosition ] * (int)Math.Pow(2, bin.Length-1 - binPosition);
                binPosition++;
               
            }
            result[pos] = number;
            Console.Write(number + " }");
            Console.WriteLine();
            Console.Write($"Data array is not long enough to source all required binary digits, last decimal is cut by {cut}");
            return result;
        }
        for (int i = 0; i < digitInfo[pos]; i++)   //количество проходов по циклу равно числу цифр в элементе info
        {
            number += bin[binPosition + i] * (int)Math.Pow(2, digitInfo[pos]-1-i); 
        }
        Console.Write(number + " ");
        binPosition += digitInfo[pos];

        // Теперь неплохо бы доработать, чтобы в массив записывался  0, если не хватает двоичных цифр.
        result[pos] = number;
    }
    Console.Write("}");
    return result;
}
*/

int[] SplitBinToDec(int[] bin, int[] digitInfo)
{
    Console.Write("{ ");
    int[] result = new int[digitInfo.Length];
    int binPosition = 0, cut = 0, cutIndex = 0;
    bool isCut = false;
    for (int pos = 0; pos < digitInfo.Length; pos++)
    {

        int number = 0;
        if (isCut) goto aftercut;
        if (binPosition + digitInfo[pos] > bin.Length)
        {
            //попробовал расширить while из 104-й до сюда для применения break, и у меня перестало показываться предупреждение, если последний элемент info четко попал на длину data, а потом пошел дальше 0-ми. 
            // if (isCut) continue; //break или continue здесь прерывают мой внешний цикл for и не записывают пустые элементы
            cut = digitInfo[pos] - bin.Length + binPosition;
            cutIndex = pos;
            isCut = true;
            while (binPosition < bin.Length)
            {
                // if (isCut) continue; //break или continue здесь перезапишут мои аналитические переменные выше,когда for по pos пойдет дальше
                number += bin[binPosition] * (int)Math.Pow(2, bin.Length - 1 - binPosition);
                binPosition++;
                
            }
        }
        else
        {
            for (int i = 0; i < digitInfo[pos]; i++)
            {
                number += bin[binPosition + i] * (int)Math.Pow(2, digitInfo[pos] - 1 - i);
            }
        }
    aftercut:
        result[pos] = number;
        Console.Write(number + " ");
        binPosition += digitInfo[pos];

    }
    Console.Write("}");
    if (isCut)
    {
        Console.WriteLine();
        Console.Write($"Data array was not long enough to source all required binary digits, last properly converted number with index {cutIndex} was cut by {cut}");
    }
    return result;
}



int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1 }; // длина 13
int[] info = { 2, 3, 0, 7, 1 , 2, 1 };
int[] decArray = SplitBinToDec(data, info);