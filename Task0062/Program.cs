// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите размера массива");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
const int CellWidth = 3;
int[,] Array = new int[a, b];
FillArray(Array);
// PrintArray(Array);  // Для проверки, создания и заполнения массива. Удалить по окончанию разработки.
int start = 1;
int i = 0;          // Текущее положение, строк.
int j = -1;         // Текущее положение, колонки. (старт с "воображаемой" колонки слева).
int row = 0;        // Движение по столбцу, может двигаться вверх (+1), вниз (-1), не двигаться по столбцам (0).
int column = 1;     // Движение по строке, может двигаться в право (+1), в лево (-1), не двигаться по строкам (0).
while (start <= a * a)

    if (0 <= i + row && i + row < Array.GetLength(1) && 0 <= j + column && j + column < Array.GetLength(0) && Array[i + row, j + column] == 0) // проверка следующей ячейки, для заполнения. 
    {
        i += row;
        j += column;
        Array[i, j] = start;
        start += 1;
    }

    else if (column == 1) { row = 1; column = 0; }
         else if (row == 1) { row = 0; column = -1; }
              else if (column == -1) { row = -1; column = 0; }
                   else if (row == -1) { row = 0; column = 1; }

PrintArray(Array);


void PrintArray(int[,] Collection)
{
    for (int i = 0; i < Collection.GetLength(0); i++)
    {
        for (int j = 0; j < Collection.GetLength(1); j++)
        {
            Console.Write($"{Collection[i, j],CellWidth}");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] Collection)
{
    for (int i = 0; i < Collection.GetLength(0); i++)
    {
        for (int j = 0; j < Collection.GetLength(1); j++)
        {
            Collection[i, j] = 0;
        }
    }
}