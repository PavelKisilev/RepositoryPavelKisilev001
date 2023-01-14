// Задача 27. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.



Console.WriteLine("Введите число для определения числа цифр");
Double chislo = Convert.ToDouble(Console.ReadLine());
int raz = 0;

// Определение типа числа и преобразование его в челое.
if ((chislo % 1) != 0) 
    {
    while  ((chislo % 1) != 0) 
    { chislo = chislo * 10;} 
    Console.WriteLine($"Число дробное, {chislo}");
    }
int celoechislo = Convert.ToInt32(chislo);         
    Console.WriteLine($"Число преобразованное, {celoechislo}");


int KolvoCeefr (int celoechislo)                        // Создадим метод для опредления колличества цифр в целом числе, путём деления на 10. (путём сравнивания остатка от деления на 1, с нулём. - можно проще.)
    {
        // int ostatok = celoechislo % 10; // деление на 10 ещё и не подходит, надо на 1. при 10-ти чифры в числах с нулями не считаются. 
        for (int i=1; celoechislo != 0; i++)
        { celoechislo = celoechislo / 10;
        //   ostatok = celoechislo % 10;
        raz = i;}
        return raz;
    }
Console.Write($"Колличество цифр в числе равно {KolvoCeefr(celoechislo)}");