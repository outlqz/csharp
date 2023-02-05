// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNum(int num)
{
    Console.Write(num + " ");
    if (num > 1) ShowNum(num - 1);
    Console.Write(num + " ");
}

ShowNum(5);
*/

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumOfDigits(int num)
{
    if (num != 0) return SumOfDigits(num / 10) + num % 10;
    else return 0;
}


// f(123) -> f(12) + 3
// f(12) -> f(1) + 2
// f(1) -> f(0) + 1
// f(0) -> 0

//Console.WriteLine(SumOfDigits(123));
*/

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void getSet(int m, int n)
{
    Console.Write(m + " ");
    if (m < n) getSet(m + 1, n);
    if (m > n) getSet(m - 1, n);
}

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

getSet(m, n);
*/

// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

double AtoDegree(double a, int b)
{
    if (b > 0) return AtoDegree(a, b - 1) * a;
    if (b < 0) return AtoDegree(a, b + 1) * 1 / a;
    else return 1;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write(AtoDegree(a, b) + "  " + AtoDegree(a, -b));