// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



Console.WriteLine("Введите число для подсчета суммы входящих в него цифр");
int x = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
int z = 0;

// 1. Необходимо узнать колличество разрядов в числе. 
int RazryidChisla (int x)
{
        for (int i=0; x>0; i++)
        {x = x / 10; 
        z=i;}
        return z;
}

int razryid = RazryidChisla (x);

// 2.  Зная колличество разрядов можно получить по отдельности каждую цифру числа.

while ( razryid >= 0 )
    {
    Sum = Sum + x / Convert.ToInt32(Math.Pow(10, razryid));   // Получаем чифру для сложения из числа.
    x = x % Convert.ToInt16(Math.Pow(10, razryid));   // Получаем новое число, с уже учтённой цифры.
    razryid = razryid - 1;
    }

Console.WriteLine($"Сумма цифр числа равна {Sum}");