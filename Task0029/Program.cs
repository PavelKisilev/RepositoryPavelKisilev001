// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

Console.WriteLine("Введите числа входящие в одномерный массив, последовательно");
int[] Massiv = new int[8];                                  // создание массива. (По умолчанию все значения элементов массива равны нулю)

for (int i = 0; i < 8; ++i)                                 // цикл, для изменения значений массива. 
    {Massiv[i] = Convert.ToInt32(Console.ReadLine());}

foreach (int el in Massiv)                                  // цикл, для вывода в одну строку значений массива. 
    {Console.Write (el+" ");}





// int PrintMassiv (int Massiv) 
//     { 
//         foreach (int el in Massiv)
//                 {Console.Write (el+" ");}
//     }
//     return 

// Console.WriteLine($" массив -> {PrintMassiv(Massiv)}");