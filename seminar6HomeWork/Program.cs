// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = 0; i < m; i++)
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) count++;
}

Console.WriteLine($"Чисел больше нуля введено - {count}.");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Найдём точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.");

double x, y, k1, b1, k2, b2;

Console.Write("Введите k1: ");
k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
b2 = Convert.ToDouble(Console.ReadLine());

x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;

Console.WriteLine($"Точка пересечения этих прямых: ({x},{y})");