Console.Clear();
// 1 вид Методов

void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1();

//  Метод 2 

void Method2(string msg)  // метод выводит сообщение
{
    Console.WriteLine(msg);
}

// Method2(msg: "Текст сообщения");

void Method21(string msg, int count) // метод выводит сообщение count раз
{
    int i = 0;
    while( i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст", 4);
// Method21(msg: "Текст", count: 4); // если переменные метода именованны то их можно менять местами
// Method21(count: 4, msg: "Новый Текст" );

// 3 ВИд метода возвращаемый

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();     // поместили результат в переменную
//Console.WriteLine(year); // вывели переменную

// 4 Вид методов принимает и возвращает

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
//Console.WriteLine(res);

string Method44(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)       // заменили while на for
    {
        result = result + text;
    }
    return result;
}
string res = Method44(10, "z");
//Console.WriteLine(res);