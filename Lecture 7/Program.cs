/*
string NumbersFor (int a,int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a,int b)
{
    if (a<b) return $"{a} " + NumbersRec(a+1,b);
    else return $"{a}";
}

Console.WriteLine(NumbersFor(1,10));
Console.WriteLine(NumbersRec(1,10));
*/

/*
// Вычислить а^n , а - основание степени, n- показатель степени
int PowerFor(int a,int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{
    // if (n == 0) return 1;
    // else return PowerRec(a,n-1)*a;
    //итернарнй оператор, запись в одну строку:
    return n ==0 ? 1: PowerRec(a, n-1)*a;
}
//используем a^(m*n) = a^m*a^n
// a^(2*n/2)
int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a*a,n/2);
    else return PowerRecMath(a,n -1)*a;
}

Console.WriteLine(PowerFor(2,10));
Console.WriteLine(PowerRec(2,10));
Console.WriteLine(PowerRecMath(2,10));
*/

// char[] s = {'a','v','c','t'};
// int count = s.Length;
// int n =1;
// for (int i = 0; i <count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         Console.WriteLine($"{n++,-3}){s[i]}{s[j]}");
//     }
// }

/*
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{    
    if (length == word.Length) 
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }    
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet,word,length+1);
    }
}
// - цикл в цикле, но для общего случая.Перебор внутреннего пишется в последнюю букву.

FindWords("avce", new char[3]);
// по комбинаторике, длина алфавита - это основание, а длина искомых комбинаций -показатель степени
*/

/*
// Обход папок рекурсией

void CatalogueInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] folders = catalog.GetDirectories();
    for (int i = 0; i < folders.Length; i++)
    {
        Console.WriteLine($"{indent}{folders[i].Name}");
        CatalogueInfo(folders[i].FullName,indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
       Console.WriteLine($"{indent}{files[i].Name}"); 
    }
}

string path = @"E:\vids\";
CatalogueInfo(path);
*/

//Ханойская башня, пазл

/*
void HanoyTowers (int slabs ,string init = "1", string fin = "3", string mid = "2" )
{
    if (slabs >1) HanoyTowers (slabs - 1, init, mid, fin) ;
    Console.WriteLine($"{init} >> {fin}");
    if (slabs >1) HanoyTowers (slabs - 1, mid,fin,init);
}

HanoyTowers(4);

*/

//обход бинарного дерева

/*
string emp = String.Empty;
string[] tree = {emp,"/","*","10","-","+",emp,emp,"4","2","1","3"};

void InOrderTraversal(int pos = 1)
{
    if (pos <tree.Length)
    {
        int left = 2*pos;
        int right = 2*pos +1;
         Console.WriteLine(tree[pos]); // - с первого налево вниз, Depth first , pre-order . первый пустой, не рисуется Node(Current)-Left-Right
        if (left <tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        // Console.WriteLine(tree[pos]); // - с левого нижнего направо по дереву(с переходом через  уровень выше в промежутке) Depth first in-order
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
        // Console.WriteLine(tree[pos]); // - с левого нижнего направо по дереву(без переход через  уровень выше в промежутке) Depth first post-order
    }
}

InOrderTraversal();

*/

decimal fRec = 0 ;

decimal FibonacciRecursion(int n, int f1 = 1, int f2 = 1 )
{
    int result = f1+f2;
    int i = 0;
    fRec++;
    i++;
    if (i == n ) return result;
    else return FibonacciRecursion(n-(n+i),f2,result);    
}

DateTime dt = DateTime.Now;

Console.ReadLine();
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"),-15} ");
    fRec = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.WriteLine();