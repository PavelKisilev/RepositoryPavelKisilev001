// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// 1.Задать два двухмерных массива;
// 2.Создать метод перемножения массивов;


Console.WriteLine("Введите колличество строк матрицы один:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцев матрицы один:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество строк матрицы два:");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцев матрицы два:");
int d = Convert.ToInt32(Console.ReadLine());

int[,] MatrixOne = new int[a,b];
int[,] MatrixTwo = new int[c,d];
int[,] MatrixThree = new int[a,d];
const int CellWidth = 3;

FillArray(MatrixOne);
FillArray(MatrixTwo);
PrintArray(MatrixOne);
Console.WriteLine();
PrintArray(MatrixTwo);
Console.WriteLine();
Multiplication(MatrixOne,MatrixTwo);
PrintArray(MatrixThree);

void FillArray(int[,] Collection)
{
    for (int i = 0; i < Collection.GetLength(0); i++)
    {
        for (int j = 0; j < Collection.GetLength(1); j++)
        {
            Collection[i,j] = new Random().Next(-10,10);
        }
    }
}

void PrintArray(int[,] Collection)
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

void Multiplication(int[,] CollectionOne, int[,] CollectionTwo)
{
    for (int o = 0; o < CollectionOne.GetLength(0); o++)    // переход на следующую ячейку (строку) новой матрицы.     
    {
        for (int i = 0; i < CollectionTwo.GetLength(1); i++)
        {
            for (int j = 0; j < CollectionTwo.GetLength(0); j++)
            {            
                // здесь заполняем столбцы новой матрицы, т.е. осуществляем переходы в пределах одной строки вправо и вписываем значения.
                MatrixThree[o,i]+=CollectionOne[o,j] * CollectionTwo[j,i]; // Заполнена первая ячейка новой матрицы.
            }
    
        }
               
    }
}

