// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void SortingInRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int k = 0; k < array.GetLength(1) - 1; k++)
            for (int j = 0; j < array.GetLength(1) - 1 - k; j++)
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
}

int[,] newArray = Create2dArray();
Show2dArray(newArray);
SortingInRows(newArray);
Show2dArray(newArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] RowSum(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sum[i] += array[i, j];
    return sum;
}

int MinSumRow(int[] array)
{
    int min_ind = 0;
    for (int i = 1; i < array.Length; i++)
        if (array[min_ind] > array[i]) min_ind = i;
    return min_ind + 1;
}

int[,] newArray = Create2dArray();
Show2dArray(newArray);
Console.WriteLine($"Строка с наименьшей суммой элементов: {MinSumRow(RowSum(newArray))}");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ProdOfMatrix(int[,] array1, int[,] array2)
{
    int size1matrix1 = array1.GetLength(0);
    int size2matrix1 = array1.GetLength(1);
    int size1matrix2 = array2.GetLength(0);
    int size2matrix2 = array2.GetLength(1);
    int[,] result = new int[size1matrix1, size2matrix2];

    if (size2matrix1 == size1matrix2)
        for (int i = 0; i < size1matrix1; i++)
            for (int j = 0; j < size2matrix2; j++)
                for (int k = 0; k < size1matrix2; k++)
                    result[i, j] += array1[i, k] * array2[k, j];
    else Console.WriteLine("Данные матрицы умножить нельзя.");
    return result;
}

Console.Write("Введите минимально возможное значение элемента: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное значение элемента: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк 1ой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1ой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк 2ой матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 2ой матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = CreateRandom2dArray(rows1, columns1, minValue, maxValue);
int[,] array2 = CreateRandom2dArray(rows2, columns2, minValue, maxValue);
Show2dArray(array1);
Show2dArray(array2);

int[,] newArray = ProdOfMatrix(array1, array2);
Console.WriteLine("Произведение этих двух матриц:");
Show2dArray(newArray);
*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] FillSqr(int size)
{
    int[,] result = new int[size, size];
    int count = result.Length;
    int row = 0;
    int col = 0;
    int dx = 0;
    int dy = 1;
    int direct = 0;
    int border = size;

    for (int i = 0; i < count; i++)
    {
        result[col, row] = i + 1;
        if (--border == 0)
        {
            border = size * (direct % 2) + size * ((direct + 1) % 2) - (direct / 2 - 1) - 2;
            int temp = dy;
            dy = -dx;
            dx = temp;
            direct++;
        }
        col += dx;
        row += dy;

    }
    return result;
}

Console.Write("Введите размер квадратного массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] newArray = FillSqr(size);
Show2dArray(newArray);