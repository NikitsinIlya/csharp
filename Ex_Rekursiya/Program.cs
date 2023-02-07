Console.Clear();
/*
double Factorial (int n)  // функция нахождения факториала рекурсией
{
    if(n == 1) return 1;
    else return n * Factorial(n - 1);       //// Рекурсия это вызов функции в функции!
}
Console.WriteLine("Введите факториал числа: ");
    int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factorial(n));
*/

// выведем последовательность фебоначчи рекурсией

int Febonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Febonacci(n-1) + Febonacci(n-2);
}

for (int i = 1; i < 10; i++)                                       // если искать больше 40 чисел рекурсия очень сильно перегружает систему! Лучше использовать цикл
{
    Console.WriteLine(Febonacci(i));
}
