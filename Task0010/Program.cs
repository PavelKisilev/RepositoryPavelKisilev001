// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обращаться к числу как к строке нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число ");
int x = Convert.ToInt32(Console.ReadLine());
x = x % 100; // получаем двухзначное число, являющиеся остатком от деления на 100.
x = x / 10;  // получаем цифру, отбрасывая остаток от деления на 10.
Console.WriteLine($"Вторая цифра введённого числа {x}");