// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите колличество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцев массива:");
int n = Convert.ToInt32(Console.ReadLine());
const int CellWidth = 3;
int numberOfMaxString = 1;
int[,] Array = new int[m,n];
FillArray(Array);
PrintArray(Array);
Console.WriteLine();
MaximumSum(Array);
Console.Write($"номер строки с наименьшей суммой элементов: {numberOfMaxString}");


void FillArray (int[,] Collection)
{
    for (int i = 0; i < Collection.GetLength(0); i++)
    {
        for (int j = 0; j < Collection.GetLength(1); j++)
        {
            Collection[i,j] = new Random().Next(-10,10);
        }
    }
}
void PrintArray (int[,] Collection)
{
    for (int i = 0; i < Collection.GetLength(0); i++)
    {
        for (int j = 0; j < Collection.GetLength(1); j++)
        {
            Console.Write($"{Collection[i,j], CellWidth}");
        }
    Console.WriteLine();    
    }
}
int MaximumSum(int[,] Collection)
{
    int sum = 0;
    
    for (int j = 0; j < Collection.GetLength(1)-1; j++)
    {
        int sum1 = Collection[0, 0]; // Поиск суммый первой строки, для дальнешего сравнения. 
        sum1 = sum1 + Array[0, j + 1];
        sum = sum1;
    }

    for (int i = 1; i < Collection.GetLength(0)-1; i++)
    {
        for (int j = 0; j < Collection.GetLength(1)-1; j++)
        {
            int sum2 = Collection[i, j];
            sum2 = sum2 + Collection[i, j + 1];
            if (sum2 < sum) { sum = sum2; numberOfMaxString=i++;}
        }
    }
return numberOfMaxString;
}
