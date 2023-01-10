// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число от 1 до 7");
int x = Convert.ToInt32(Console.ReadLine());
if (x==1) {Console.WriteLine("Понедельник");}
else if (x==2) {Console.WriteLine("Вторник");}
else if (x==3) {Console.WriteLine("Среда");}
else if (x==4) {Console.WriteLine("Четверг");}
else if (x==5) {Console.WriteLine("Пятница");}
else if (x==6) {Console.WriteLine("Суббота");}
else if (x==7) {Console.WriteLine("Воскресенье");}
else Console.WriteLine ("Некорректное число");