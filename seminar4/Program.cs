// Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*
int GetSum(int num)
{
    int sum = 0;

    for(int current = 1; current <= num; current++) sum += current;

    return sum;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.WriteLine(result);
*/

// Задача 2. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/*
int GetProd(int num)
{
    int prod = 1;

    for(int current = 1; current <= num; current++) prod *= current;

    return prod;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetProd(a);
Console.WriteLine(result);
*/

// Задача 3. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*
int Numbers(int num)
{
    int count = 0;

    while (num != 0)
    {
        num = num / 10;
        count++;
    }

    return count;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int count = Numbers(a);
Console.WriteLine(count);
*/

// Программа 4. Вывод массива

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
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