// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели, от 1 до 7 ");
int x = Convert.ToInt32(Console.ReadLine());


if (x == 1) {Console.WriteLine("Нет");}
else if (x == 2) {Console.WriteLine("Нет");}
else if (x == 3) {Console.WriteLine("Нет");}
else if (x == 4) {Console.WriteLine("Нет");}
else if (x == 5) {Console.WriteLine("Нет");}
else if (x == 6) {Console.WriteLine("Да");}
else if (x == 7) {Console.WriteLine("Да");}
else {Console.WriteLine("Введенно неверное число");}