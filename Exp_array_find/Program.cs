Console.Clear();
// Найти n член массива
/*
int[] array = { 31, 82, 13, 4, 55, 65, 74, 8 };

int n = array.Length; // - Опеределение длинны массива
int find = 4; 

int index = 0;

while (index < n )
{
    if (array[index] == find) 
    {   Console.WriteLine(index);
        break;
    }
    index++;
}
*/

// Сделаем заполнение массива случайным и опишем функцию вывода.
// void - это метод без return он не возвращает результат
/*
void FillArray(int[] collection)   // функция заполнения массива случайными числами от 1 до 10 
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // Функция печати элементов массива
{
    int count = col.Length;
    int position = 0;
    while( position < count)
    {
        Console.Write($" {col[position]} ,");
        position++;
    }
}

int IndexOf(int[] collection, int find) // поиск элемента в массиве
{
    int count = collection.Length;
    int position = -1;  // это позволит при отсуствии элемента в массиве вывести -1 !
    int index = 0;
    while(index < count)
    {
        if( collection[index] == find)
        {   
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создать новый массив на 10 чисел по умолчанию все значения будут нули!
// array[4] = 4;  - замена 4 элемента в массиве.
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
*/

//Task

// Сортировка массива от мин к макс.

// 1. Найти мин 2. заменить знач 3. повторить до конца массива

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

