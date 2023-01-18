// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Начинайте вводить числа, по окончанию ввода введите End"); 
string element = string.Empty;
string end = "End";
int i = 0;
element = Console.ReadLine();    
    
    while (element != end ) 
    {   if (Convert.ToInt32(element)>0) {i++;}
    Console.WriteLine("Вводите следующие число");
    element = Console.ReadLine();
    } 
        
Console.WriteLine($"Число положительных чисел рано {i}");