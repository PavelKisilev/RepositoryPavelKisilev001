
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// Этапы выолненения работы:
// 1. Сформировать массив данных посредством ввода с клавиатуры, превышающий 3 символа.
// 2. преобразовать полученный массив, в удовлетворяющий условию.
// 3. вывести полученный результат на экран.
// Работы пыполнять с использованием логики проектирования приложений "Сверху-вниз".


Console.WriteLine("Введите размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());
String[] Mass = new String[sizeArray];
InputSymbol(Mass);
Change(Mass); // снижение колличества символов в массиве до 3-х и менее.
PrintArray(Mass); // печать символов массива.


void PrintArray(string[] Array)
{
    string symbol = "";
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{symbol + Array[i]}, ");
    }
}

void InputSymbol(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine("Введите символ или символы");
        Array[i] = new(Console.ReadLine());
        while (Array[i].Length <= 1)
        {
            Console.WriteLine("Введите дополнительный символ");
            Array[i] = new(Array[i] + Console.ReadLine());
        }
    }
}

void Change(string[] Array)
{
    int sumSymbol = 0;
    
    for (int i = 0; i < Array.Length; i++)
    {
        sumSymbol = Array[i].Length + sumSymbol;
    }

    while (sumSymbol > 3)
    {        
        int index = new Random().Next(0, sizeArray++);
        int deleted = Array[index].Length;
        Array[index] = "";
        sizeArray--;
        sumSymbol = sumSymbol - deleted;
    }
}