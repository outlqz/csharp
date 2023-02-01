// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
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

void ChangeRows(int[,] array, int r1, int r2)
{
    if (r1 >= 0 && r1 < array.GetLength(0) &&
       r2 >= 0 && r2 < array.GetLength(0) &&
       r1 != r2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[r1, j];
            array[r1, j] = array[r2, j];
            array[r2, j] = temp;
        }
    }
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

Console.Write("Input a number of 1st row to change: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of 2nd row to change: ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(newArray, r1, r2);
Show2dArray(newArray);
*/

// Задача 1. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
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

void TransposeMatrix(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    int temp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = temp;
                }
}   



int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

TransposeMatrix(newArray);
Show2dArray(newArray);
*/

// Задача 2. Из двумерного массива целых чисел удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min number: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max number: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)//rows indexes
    {
        for (int j = 0; j < array.GetLength(1); j++)//columns indexes
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] MinArrayIndex(int[,] mas)
{
    int[] indexes = new int[2];//index of row and index of column with MIN value
    indexes[0] = 0;
    indexes[1] = 0;
    for (int i = 0; i < mas.GetLength(0); i++)
        for (int j = 0; j < mas.GetLength(1); j++)
            if (mas[i, j] < mas[indexes[0], indexes[1]])
            {
                indexes[0] = i;
                indexes[1] = j;
            }
    return indexes;
}

int[,] RemoveMinIndexes(int[] indexes, int[,] mas)
{
    int[,] resmas = new int[mas.GetLength(0) - 1, mas.GetLength(1) - 1];
    int i2 = 0;
    int j2 = 0;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        if (i != indexes[0])
        {
            for (int j = 0; j < mas.GetLength(1); j++)
                if (j != indexes[1])
                {
                    resmas[i2, j2] = mas[i, j];
                    j2++;
                }
            j2 = 0;
            i2++;
        }
    }
    return resmas;
}

int[,] mas = CreateRandom2dArray();
Show2dArray(mas);
int[] indexes = MinArrayIndex(mas);
int[,] mas2 = RemoveMinIndexes(indexes, mas);
Console.WriteLine($"MIN = [{indexes[0]} : {indexes[1]}] = {mas[indexes[0], indexes[1]]}");
Show2dArray(mas2);
*/
// Вариант 2

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] FindMin(int[,] array)
{
    int[] minPosition = new int[2];
    int minValue = array[0,0];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < minValue)
            {
                minValue = array[i,j];
                minPosition[0] = i;
                minPosition[1] = j;
            }
        }
    }

    return minPosition;
}

int[,] RemoveArray(int[,] array, int[] Position)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            newArray[i-Convert.ToInt32((i>=Position[0] + 1)),j-Convert.ToInt32((j>=Position[1] + 1))] = array[i,j];
        }
    }

    return newArray;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

int[] minValue = FindMin(newArray);
Console.WriteLine($"{minValue[0]} {minValue[1]}");
int[,] newArray2 = RemoveArray(newArray, FindMin(newArray));
Show2dArray(newArray2);