// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}
int EvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return count;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write(array[i] + "  ");
    Console.WriteLine();
}
Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(length);
PrintArray(array);
Console.WriteLine($"Количество чётных чисел в данном массиве - {EvenNumber(array)}.");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int SumOfOddPosed(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2) sum += array[i];
    return sum;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Input an array length: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length, min, max);
ShowArray(array);

Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях массива равна {SumOfOddPosed(array)}");
*/

// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    Random doubleRand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next((int)minValue, (int)maxValue + 1) + doubleRand.NextDouble();
    }
    return array;
}

double Diff(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }

    return (max - min);
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write(array[i] + "  ");
    Console.WriteLine();
}

Console.Write("Input an array length: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a max possible value: ");
double max = Convert.ToDouble(Console.ReadLine());

double[] array = CreateRandomArray(length, min, max);
ShowArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Diff(array)}.");