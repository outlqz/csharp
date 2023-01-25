//Напишите программу, которая перевернёт одномерный массив.
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

void ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
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

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);
ReverseArray(newArray);
ShowArray(newArray);
*/

// Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
bool existTriangle(int firstSide, int secondSide, int thirdSide)
{
    return (firstSide + secondSide > thirdSide) && (secondSide + thirdSide > firstSide) &&
    (thirdSide + firstSide > secondSide);
}

Console.Write("Введите первое число: ");
int firstSide = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondSide = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdSide = Convert.ToInt32(Console.ReadLine());

if (existTriangle(firstSide, secondSide, thirdSide)) Console.WriteLine("Треугольник может существовать.");
else Console.WriteLine("Треугольник не может существовать.");
*/

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
void Fibonacci(int a, int b, double[] array)
{
    array[0] = a;
    array[1] = b;

    for (int i = 2; i < array.Length; i++) 
    {
        array[i] = array[i-1] + array[i-2];
    }
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 'a': ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 'b': ");
int b = Convert.ToInt32(Console.ReadLine());

double[] array = new double[n];

Fibonacci(a, b, array);
ShowArray(array);
*/

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }

    return array;
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++) newArray[i] = array[i];

    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size);
ShowArray(newArray);

int[] copyArray = CopyArray(newArray);

newArray[0] = 200;
ShowArray(newArray);
ShowArray(copyArray);