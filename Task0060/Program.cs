// Задача 60. ...Сформируйте трёхмерный массив из уникальных двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.Write("Введите измерении массива i ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите измерении массива k ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите измерении массива j ");
int j = Convert.ToInt32(Console.ReadLine());
const int CellWidth = 3;
int[,,] Array = new int[i, k, j];
FillArray(Array);
PrintArray(Array);


void FillArray(int[,,] Collection)
{
    for (int i = 0; i < Collection.GetLength(0); i++)
    {
        for (int k = 0; k < Collection.GetLength(1); k++)
        {
            for (int j = 0; j < Collection.GetLength(2); j++)
            {                                 
                int temp;
                while (true)
                {
                    temp = new Random().Next(10, 99);
                    if (Check(Collection, temp)) continue;
                    else break;
                }
                Collection[i, k, j] = temp;
            }
        }
    }
}

bool Check(int[,,] Collection, int value)
{
    for (int i = 0; i < Collection.GetLength(0); i++)
    {
        for (int k = 0; k < Collection.GetLength(1); k++)
        {
            for (int j= 0; j < Collection.GetLength(2); j++)
            {
                if (Collection[i, k, j] == value) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] Collection)
{
    for (int i = 0; i < Collection.GetLength(0); i++)
    {
        for (int k = 0; k < Collection.GetLength(1); k++)
        {
            for (int j = 0; j < Collection.GetLength(2); j++)
            {
                Console.Write($"{Collection[i, k, j],CellWidth}");

                Console.Write($"({k}, {j}, {i}) ");

                
            }
            Console.WriteLine();
        }   
        
    }

}

