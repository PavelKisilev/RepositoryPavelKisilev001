// Задача: Напишитие программу, которая выводит третью цифру заданного числа или сообщает. что третьей цифры нет.
// 645 -> 5
// 57 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine()); // получили число
int y=0;
int z=x;
Console.WriteLine("Запущен цикл");

while (z != 0) // Цикл позволяет определить число разрядов. 
    {
        z=z/10;            // Цикл надо остановить, в момент равенства остатка нулю.
        y=y+1;
        Console.WriteLine(z);
        Console.WriteLine(y);
    } 

Console.WriteLine("Остановлен цикл");

if (y<3) {Console.Write("Третьей цифры нет");}// Если y<3 то третьей цифры нет, "y" - счётчик числа разрядов.
else                                          // Иначе выводим третью цифру. 
{ 
    int x1=Convert.ToInt32(Math.Pow(10,(y-3)));
    Console.WriteLine(x1);
    x=x/x1;
    x=x%10;
    Console.Write(x);
}

