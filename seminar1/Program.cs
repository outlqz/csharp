// Семинар 1.

// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

/*
Console.Write("Input number1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(quad2 == num1) Console.Write("Число " + num1 + " является квадратом числа " + num2);
else Console.Write("Число " + num1 + " НЕ является квадратом числа " + num2);
*/

// Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current <= number)
{
    Console.Write(current + " ");
    current++;
}
*/

/*
32465 / 10 = 3246
32465 / 100 = 324
32465 / 1000 = 32
32465 / 10000 = 3

32465 % 10 = 5
32465 % 100 = 65
32465 % 1000 = 465
32465 % 10000 = 2465
*/