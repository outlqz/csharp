// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

/*
double Function(double anum, double bnum)
{
    double result = 1;
    for(int i = 0; i < bnum; i++) result = result * anum;
    return result;
}

Console.Write("Введите число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите степень: ");
double b = Convert.ToDouble(Console.ReadLine());

double res = Function(a, b);
Console.WriteLine(res);
*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int SumOfNumbers(int num)
{
    int sum = 0;
    for(int i = num; i != 0; i /= 10)
    {
        sum += i % 10;
    }
    return sum;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumOfNumbers(number);

Console.WriteLine("Cумма цифр числа " + number + " равна " + sum + ".");
*/


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

/*
int[] CreateArray(int length)
{
    int[] array = new int[length];

    for(int i = 0; i < length; i++)
    {
        Console.Write($"Введите "+ (i + 1) + "ый элемент: ");
        array[i]= Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array) 
{ 
    Console.Write("Массив - ["); 
    for (int i = 0; i < array.Length - 1; i++)  Console.Write(array[i] + ", "); 
    Console.Write(array[array.Length - 1] + "]"); 
    Console.WriteLine(); 
}

Console.Write("Введите длину массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(m);
PrintArray(array);
*/