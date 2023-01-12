// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Enter the integer number");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the seconf integer number");
int x2 = Convert.ToInt32(Console.ReadLine());
int x0 = x1%x2;
if (x0 == 0) {Console.WriteLine("Кратно");}
else { Console.Write($"Не кратно, остаток {x0}");}