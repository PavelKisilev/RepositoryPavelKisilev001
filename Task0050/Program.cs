// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите длину строки массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите высоту столбца массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
const int CellWidth = 4; 
Console.WriteLine("Введите значение искомого элемента");
int Elementfaind = Convert.ToInt32(Console.ReadLine());
int[] position = new int[2];

void FillArray(int[,] collection, int[] position)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            collection[i,j] = new Random().Next(-10,11);            
            if (collection[i,j] == Elementfaind) 
            {
                position[0] = i+1;
                position[1] = j+1;
                break;
            }            
        }    
    }
    if (position[0] == 0) Console.WriteLine("Такого числа в массиве нет");
    else Console.WriteLine($"Позиция искомого элемента: Строка номер {position[0]}, столбец номер {position[1]}");
}

void PrintArray(int[,] collection)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           Console.Write($"{collection[i,j], CellWidth}");          
        }  
        Console.WriteLine();  
    }
}

FillArray(array, position);
PrintArray(array);