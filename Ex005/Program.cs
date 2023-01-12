int X = new Random().Next(10,100000);
Console.WriteLine($"Было сгенерированно случайно число {X}");
int X1 = X / 100;
int X2 = X % 10;

int Y=X1*10+X2;
Console.WriteLine(Y);