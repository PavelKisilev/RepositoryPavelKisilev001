// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5

void InputMeaning(double [] InputMean)
{
    double x = 0;
    double y = 0;
    x = (InputMean[2] - InputMean[0]) / (InputMean[1] - InputMean[3]);
    y = InputMean[1] * (x) + InputMean[0];

    double[] IntersectionPoint = { x, y };
    for (int i = 0; i < IntersectionPoint.Length; i++)
    {
        Console.WriteLine($"Точка пересечения ( {IntersectionPoint[0]} , {IntersectionPoint[1]} )");
    }
}

double[] InputMean = new double[4]; // Создаётся массив для заполнения входящими значениями двух прямых.
{ Console.WriteLine($"Введите значение чисел b1, k1, b2 и k2 поочерёдно: "); }
    for (int i = 0; i < InputMean.Length; i++)
    {
        InputMean[i] = Convert.ToDouble(Console.ReadLine());
    }


InputMeaning(InputMean);






// Console.WriteLine($"Введите значение числа b1 : ");
// int b1 = Convert.ToInt32(Console.Read());
// Console.WriteLine($"Введите значение числа b1 : ");
// int b2 = Convert.ToInt32(Console.Read());
// Console.WriteLine($"Введите значение числа b1 : ");
// int k1 = Convert.ToInt32(Console.Read());
// Console.WriteLine($"Введите значение числа b1 : ");
// int k2 = Convert.ToInt32(Console.Read());

// double x = 0;
// double y = 0;


// void InputMeaning(int b1, int b2, int k1, int k2)
// {
//     x = (b2 - b1) / (k1 - k2);
//     y = k1*(x) + b1;

//     double[] IntersectionPoint = { x, y };
//     for (int i = 0; i < IntersectionPoint.Length; i++)
//     {
//         Console.WriteLine(IntersectionPoint[i]); 
//     }
// }

// InputMeaning(b1,b2,k1,k2);