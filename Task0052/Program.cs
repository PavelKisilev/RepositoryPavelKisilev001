// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите колличество строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцев массива");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m,n];
const int CellWidth = 3;
double arithmeticMeanVariable = 0;
double temp = 0;
FillArrya(array);
PrintArrya(array);
ArithmeticMean(array);

void FillArrya (double[,] Collection)   // Создаётся массим с случайными числами, заданного размера.
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(-10,10);
        }
    }
}

void ArithmeticMean (double[,] Collection)  // Для каждого столбца высчитывается среднеарфметическое значение, и записывается в строку. 
{Console.Write("Среднее арифметическое каждого столбца: "); // Запись заголовка.
    for (int j = 0; j< n; j++)
    {
        for (int i = 0; i < m; i++) 
        {
        arithmeticMeanVariable = arithmeticMeanVariable + array[i,j];   // Расчет и запись в переменную. 
        temp = i+1;     // Использование временной переменной для деления суммы чисел столбца на их колличество. 
        }

        Console.Write($"{Math.Round(arithmeticMeanVariable/temp,1), CellWidth}; ");  // Запись полученного значение в строку после заголовка.
        arithmeticMeanVariable = 0;     // Обнуления суммы чисел столбца, для начало работы со следующий.
    }
    
}

void PrintArrya (double[,] Collection)
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
