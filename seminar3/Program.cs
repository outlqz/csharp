// Семинар3. 

// Задача 1. Написать программу, которая по заданному номеру четверти покажет
// диапазон возможных координат точек в этой четверти.

/*
void GetDiapazone (int quadrant)
{
    if(quadrant == 1) Console.WriteLine("x > 0 and y > 0.");
    else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0.");
    else if(quadrant == 3) Console.WriteLine("x < 0 and y < 0.");
    else if(quadrant == 4) Console.WriteLine("x > 0 and y < 0.");
    else Console.WriteLine("Wrong input!");
}

Console.WriteLine("Input a number of quadrant: ");
int quadNum = Convert.ToInt32(Console.ReadLine());

GetDiapazone(quadNum);
*/

// Задача2. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
void GetFunct(double xPos, double yPos)
{
    if(xPos == 0 || yPos == 0) Console.WriteLine("Координаты не должны быть равны 0");
    else
    {
        if(xPos > 0 && yPos > 0) Console.WriteLine("1");
        else if(xPos < 0 && yPos > 0) Console.WriteLine("2");
        else if(xPos < 0 && yPos < 0) Console.WriteLine("3");
        else if(xPos > 0 && yPos < 0) Console.WriteLine("4");
    }
}

Console.Write("Введите х: ");
double xNum = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y: ");
double yNum = Convert.ToDouble(Console.ReadLine());

GetFunct(xNum, yNum);
*/

// Задача3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

/*
void Funct(int n)
{
    int count = 1;

    while(count <= n)
    {
        int quad = count * count;
        Console.WriteLine($"{count} > {quad}");
        count++;
    }
}

Console.Write("Введите N: ");
int num = Convert.ToInt32(Console.ReadLine());

Funct(num);
*/

// Задача4. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

double GetFunct(double xPos1, double yPos1, double xPos2, double yPos2)
{
    return Math.Sqrt(Math.Pow(xPos1 - xPos2, 2) + Math.Pow(yPos1 - yPos2, 2));
}

Console.Write("Введите 'х' первой точки: ");
double xNum1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 'y' первой точки: ");
double yNum1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 'х' второй точки: ");
double xNum2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 'y' второй точки: ");
double yNum2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(GetFunct(xNum1, yNum1, xNum2, yNum2));