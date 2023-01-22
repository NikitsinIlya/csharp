// запись функции f(x)= x²+1
/*
double f(double x)
{
    double result = x * x + 1;
    return result
}
*/

// функция нахождения максимума

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
/*
int a1 = 4;
int b1 = 44;
int c1 = 454;
int a2 = 44;
int b2 = 41;
int c2 = 94;
int a3 = 34;
int b3 = 454;
int c3 = 84;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
*/ 
// Заменим ввод переменных массивом

// индексы       0   1   2   3   4   5  6   7   8
int[] array = { 31, 82, 13, 46, 55, 65, 74, 8, 94 };

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));


Console.WriteLine(max);