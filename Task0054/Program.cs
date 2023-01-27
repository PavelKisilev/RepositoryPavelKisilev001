// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите колличество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцев массива:");
int n = Convert.ToInt32(Console.ReadLine());
const int CellWidth = 3;

int[,] Array = new int[m,n];
FillArray(Array);
PrintArray(Array);
Console.WriteLine();
Sorting(Array);
PrintArray(Array);


void FillArray(int[,] Collection)
{
    for (int i = 0; i < Collection.GetLength(0); i++)
    {
        for (int j = 0; j < Collection.GetLength(1); j++)
        {
            Collection[i,j] = new Random().Next(-10, 10);
        }
    }
}

void PrintArray (int[,] Collection)
{
    for (int i = 0; i < Collection.GetLength(0); i++)
    {
         for (int j = 0; j < Collection.GetLength(1); j++)
        {
            Console.Write($"{Collection[i,j], CellWidth};");
        }
    Console.WriteLine();
    }
}

void Sorting(int[,] Collection)
{
    for (int a = 0; a < Collection.GetLength(1); a++)
    {
        for (int i = 0; i < Collection.GetLength(0); i++)
        {
            for (int j = 0; j < Collection.GetLength(1)-1; j++)
            {  
                {
                    if (Collection[i, j] < Collection[i, j + 1])
                    {
                        int temp = Collection[i, j];
                        Collection[i, j] = Collection[i, j + 1];
                        Collection[i, j + 1] = temp;
                    }
                    
                }
            }
        }
    }
}
