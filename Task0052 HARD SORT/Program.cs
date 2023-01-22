// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

Console.WriteLine("Введите колличество строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцев массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
const int CellWidth = 3;
Console.WriteLine("Массив до сортировки");
FillArrya(array);
PrintArrya(array);

Console.WriteLine("Массив после сортировки");
Sorting(array);
PrintArrya(array);

void FillArrya (int[,] Collection)   // Создаётся массим с случайными числами, заданного размера.
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(-10,10);
        }
    }
}

void PrintArrya (int[,] Collection)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i,j], CellWidth} ");
        }
    Console.WriteLine();
    } 
    
}

void Sorting(int[,] collection)
{
    for (int i = 0; i < m; i++)
    {
        if (i+1<m) 
        {
                if (collection[i,j] > collection[i,j+1]) 
                    {
                    int temp = collection[i,j];
                    (collection[i,j]) = (collection[i,j+1]);
                    (collection[i,j+1]) = temp;
                    }
        }

        for (int j = 0; j < n; j++)
        {
            if (j+1<n & i+1<m)
            {               
                if (collection[i,j] > collection[i+1,j]) 
                    {
                    int temp = collection[i,j];
                    (collection[i,j]) = (collection[i+1,j]);
                    (collection[i+1,j]) = temp;
                    }
            }
        }
    }
}





// void Sorting (int[,] collection)
// {
//      for (int i = 0; i+1 < m; i++)
//     {
//         min = array[i;j];
//         if min>array[i]
        
//         for (int j = 0; j+1 < n; j++)
//         {

//                 if (collection[i,j] > collection[i+1,j]) 
//                 { 
//                     (collection[i,j], collection[i+1,j]) = (collection[i+1,j], collection[i,j]);
                    
//                 }
                 
//                  if (collection[i,j] > collection[i,j+1]) 
//                 { 
//                     (collection[i,j], collection[i,j+1]) = (collection[i,j+1], collection[i,j]);
//                 }
            
//         }
//     }
// }