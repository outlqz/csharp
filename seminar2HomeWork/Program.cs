// ДЗ к Семинару 2.

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

/*
int ShowNumber(int number)
{
    int dozens = number / 10;
    int result = dozens % 10;
    
    return result;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000) Console.WriteLine(ShowNumber(num));
else Console.WriteLine("Ваше число НЕ является трёхзначным");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

/*
int ShowNumber(int number)
{
    while(number > 999) number = number / 10;

    int result = number % 10;

    return result;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 100) Console.WriteLine(ShowNumber(num));
else Console.WriteLine("Третьей цифры нет.");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

/*
bool Day(int num)
{
    if(num == 6 || num == 7)
        return true;
    else
        return false;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Day(num));
*/