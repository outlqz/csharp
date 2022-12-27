// ДЗ к Семинару 3.

// Задача 19. Напишите программу, которая принимает на вход число
// и проверяет, является ли оно палиндромом.

// Тут честно скажу - подсмотрел метод( но его к сожалению скинули прямо перед глазами
// и до того как садился решать, поэтому не ознакомиться было сложно, а из головы уже не выкинешь)
// Но - посидел, прогнал поступенчато, разобрался почему так и почему не так, тестами погонял

/*
bool CheckPalindrome(long num)
{
    long check = 0;
    long numcopy = num;

    while(num > 0)
    {
        check = check * 10 + num % 10;
        num = num / 10;
    }
    return check == numcopy;
}

Console.Write("Введите число: ");
long num = Convert.ToInt64(Console.ReadLine());

if(CheckPalindrome(num)) Console.WriteLine($"Число {num} является палиндромом.");
else Console.WriteLine($"Число {num} НЕ является палиндромом.");
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

/*
double GetDistance(double xPos1, double yPos1, double zPos1, double xPos2, double yPos2, double zPos2)
{
    return Math.Round(Math.Sqrt(Math.Pow(xPos2 - xPos1, 2) + Math.Pow(yPos2 - yPos1, 2) + Math.Pow(zPos2 - zPos1, 2)), 2);
}

Console.Write("Введите 'х' первой точки: ");
double xNum1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 'y' первой точки: ");
double yNum1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 'z' первой точки: ");
double zNum1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 'х' второй точки: ");
double xNum2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 'y' второй точки: ");
double yNum2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 'z' второй точки: ");
double zNum2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(GetDistance(xNum1, yNum1, zNum1, xNum2, yNum2, zNum2));
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void GetCube(int n)
{
    int count = 1;

    while(count <= n)
    {
        double cube = Math.Pow(count, 3);
        Console.WriteLine($"{count} >>> {cube}");
        count++;
    }
}

Console.Write("Введите N: ");
int num = Convert.ToInt32(Console.ReadLine());

GetCube(num);
*/