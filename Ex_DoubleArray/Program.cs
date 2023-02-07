Console.Clear();
// string[,] table = new string[2, 3]; // - массив строк из 2 строк и 3 столбцов
// int[,] matrix  = new int[5, 8]; // - массив таблица чисел или матрица 5 строк на 8столбцов
// индексы начинаются с 0 ! тоесть первый элемент имеет индекс [0, 0]
/*
string[,] table = new string[2, 5]; 
table[1, 2] = "слово"; // элемент в 1 строке 2 столбце

for (int rows = 0; rows < table.GetLength(0); rows++)                         // цикл печати двумерного массива
{
    for ( int columns = 0; columns < table.GetLength(1); columns++)           // table.GetLength(0) количество строк table.GetLength(1) количество столбцов
    {
        Console.Write($"-{table[rows, columns]}-");
    }
    Console.WriteLine();
}
*/
void PrintArray(int[,] matr)
{                       
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for ( int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);    
PrintArray(matrix);