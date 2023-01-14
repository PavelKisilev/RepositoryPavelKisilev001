// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Функции

int StepenChisla (int A, int B)  
    {
        int x = A;
        for(int i=0; i<(B-1; i++) {A=A*x;}
        return A;
    }

// Код программы 

Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Число B");
int B = Convert.ToInt32(Console.ReadLine());

int C = StepenChisla(A, B);

Console.WriteLine($"Натуральная степень В числа А равно {C}");