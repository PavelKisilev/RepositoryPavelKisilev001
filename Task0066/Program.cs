// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.WriteLine("Введите натуральное число M"); 
int M = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите натуральное число N"); 
int N = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(AllNumber(N)); 
 
int AllNumber(int max) 
{ 
    if (M==max) return max; 
    return   max + AllNumber(max-1); 
}