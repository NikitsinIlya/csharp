Console.Clear();
/*
//  Сложение до n циклом

int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}
Console.WriteLine(SumFor(10));

// Сложение до n рекурсией

int SumRec(int n)
{
    if(n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumRec(10));

// Факториал циклом

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}
Console.WriteLine(FactorialFor(10));

// Факториал рекурсией

int FactorialRec(int n)
{
    if(n == 1) return 1;
    else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialRec(10));

// а в степени n цикл

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
Console.WriteLine(PowerFor(2, 10));

// а в степени n Рекурсия

int PowerRec(int a, int n)
{
    if(n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
Console.WriteLine(PowerRec(2, 10));
// заменим 1 строкой
int PowerRec2(int a, int n)
{
    return n == 0 ? 1 : PowerRec2(a, n - 1) * a;
}
Console.WriteLine(PowerRec2(2, 10));
*/
/*
// Перебор возможных вариаетов из букв

void FindWords(string alphabet, char[] word, int length = 0 )
{
    if (length == word.Length)
    {
        Console.WriteLine($"{new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[4]);
*/
// Обход папок с помощью win api
/*
string path = "/Личная папка/GeekBrains/CSharp/csharp/Ex_RekursiyaDop";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
*/
/*
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }
    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = @"/Личная папка/GeekBrains/CSharp/csharp/Ex_RekursiyaDop";
CatalogInfo(path);
*/

// Игра в башенки рекурсией count - кол-во блинов
/*
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();
*/

// Обход разных структур (бинарное дерево https://en.wikipedia.org/wiki/Tree_traversal ) ((4 - 2 )*(1 + 3)) / 10
/*
string emp = String.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" }; // описание бинарного дерева 
void InOrderTraversal(int pos = 1) 
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left); 
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal();
*/

// ИНЫЕ ДЕРЕВЬЯ
// Двоичное дерево - https://ru.wikipedia.org/wiki/%D0%94%D0%B2%D0%BE%D0%B8%D1%87%D0%BD%D0%BE%D0%B5_%D0%B4%D0%B5%D1%80%D0%B5%D0%B2%D0%BE
// про способы обхода - https://ru.wikipedia.org/wiki/%D0%9E%D0%B1%D1%85%D0%BE%D0%B4_%D0%B4%D0%B5%D1%80%D0%B5%D0%B2%D0%B0


