// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число 1");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int y = Convert.ToInt32(Console.ReadLine());
if (x == y*y) { Console.WriteLine("Первое число является квадратом второго");} 
else {Console.WriteLine("Первое число не является квадратом второго"); }