// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Введите количество строк (m): ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов (n): ");
    int columns = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];
    Random doubleRand = new Random();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(1, 101) + doubleRand.NextDouble();

    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j], 2) + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{ 
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void Checking(int a, int b, int[,] array)
{
    if (a < 0 || a >= array.GetLength(0) || b < 0 || b >= array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет.");
    }
    else
    {
        Console.WriteLine($"Значение элемента: {array[a, b]}");
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(newArray);
Console.WriteLine();

Console.Write("Введите номер нужной строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер нужного столбца: ");
int b = Convert.ToInt32(Console.ReadLine());
Checking(a - 1, b - 1, newArray);
*/
// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] Create2dArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимально возможное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимально возможное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindAvg(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        double avg = sum / array.GetLength(0);
        Console.WriteLine($"Среднее арифметическое элементов столбца {j+1} = {avg}");
    }
}


int[,] newArray = Create2dArray();
Show2dArray(newArray);
FindAvg(newArray);
*/