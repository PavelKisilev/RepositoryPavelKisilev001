// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число (N)");
int x = Convert.ToInt32(Console.ReadLine());
int y = 1;
int z = 1;
while (y<=x)
    {
    z = Convert.ToInt32(Math.Pow(y,3));
    Console.Write($"{z}, ");
    y=y+1;
    }
