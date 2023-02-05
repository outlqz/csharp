// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNum(int num)
{
    Console.Write(num + " ");
    if (num > 1) ShowNum(num - 1);
}

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNum(n);
*/

// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int GetSum(int n, int m)
{
    if (n > m) return m + GetSum(n, m + 1);
    if (m > n) return n + GetSum(n + 1, m);
    else return n;
}

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел в этом промежутке равна {GetSum(m, n)}.");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int Function(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return Function(n - 1, 1);
    else return Function(n - 1, Function(n, m - 1));
}

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана равна {Function(m, n)}.");