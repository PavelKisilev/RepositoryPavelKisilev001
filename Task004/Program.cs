// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите 1-ое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-ее число");
int z = Convert.ToInt32(Console.ReadLine());
int Max = 0;

if (x>y) {Max = x;} 
else Max=y;
if (Max<z) {Max = z;} 


Console.Write($"Максимальное число равно {Max}");