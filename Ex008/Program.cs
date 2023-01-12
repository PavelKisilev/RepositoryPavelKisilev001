// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число 1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int x2 = Convert.ToInt32(Console.ReadLine());
if (x1*x1==x2 || x2*x2==x1) {Console.WriteLine("Yes");}
else {Console.WriteLine("No");}





// if (x1>x2) {x3 = x1;} // Вычисление логарифма большего числа, как наиболее вероятного для квадрата.
// else {x3 = x2;}
// int x4 = Convert.ToInt32(Math.Log2(x3));
// if ( x4==x2 || x4==x1 ) {Console.Write("да");} // определение является ли одно число квадратом другого.
// else {Console.Write("Нет");}