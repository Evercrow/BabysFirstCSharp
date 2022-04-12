// Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих.

/*
int listFib = 3;
int FibonacciCustom(int pos, int f1, int f2)
{
    if (pos == 2) return 1;
    else
    {
        Console.WriteLine($"{pos - pos + listFib}) {f1 + f2}");
        listFib++;
        return FibonacciCustom(--pos, f2, f1 + f2);
    }
}

int n = 10;
int start1 = 4;
int start2 = 6;
Console.WriteLine($"1) {start1}");
Console.WriteLine($"2) {start2}");
FibonacciCustom(n, start1, start2);
*/

// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, 
// которые можно построить из букв этого алфавита.
/*
int list = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{    
    if (length == word.Length) 
    {
        Console.WriteLine($"{list++}) {new String(word)}"); return;
    }    
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet,word,length+1);
    }
}

Console.WriteLine("Enter the length n of searched word:");
int n = Convert.ToInt32(Console.ReadLine());
FindWords("aecv",new char[n]);
*/

// void PrintWords(string alphabet,int wordLength,string currentWord = "")
// {
//     if (wordLength == 0) Console.WriteLine(currentWord);
//     else 
//     {
//         for (int i = 0; i < alphabet.Length; i++)
//         {
//             PrintWords(alphabet,wordLength-1,currentWord+alphabet[i]);
//         }
//     }
// }

// int n = 4;
// PrintWords("aecv", n);



// Задача: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
//В массиве data хранится информация о количестве бит, которые занимают числа из массива info.
//Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

// Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); 
// третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)

// Пример:

// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }

// выходные данные:
// 1, 7, 0, 1

/*
int[] data = {1, 0, 1, 1, 1, 0, 0, 0, 1 };
int[] info = {2, 3, 3, 1 };

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
int[] decArray = SplitBinToDec(data, info); 
*/
