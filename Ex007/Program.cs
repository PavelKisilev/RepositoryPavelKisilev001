// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да
Console.WriteLine("Введи число для провеки");
int X = Convert.ToInt32(Console.ReadLine());

if (X % 7 == 0) 
    {
    if (X % 23 == 0) {Console.Write("Кратно");}
    
    else {Console.Write("Не кратно");}
    }
else {Console.Write("Не кратно");}