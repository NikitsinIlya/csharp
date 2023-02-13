Console.Clear();

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