// Семирар2. Методы.

// Задача 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

/*
int CutNumber(int number)
{
    int sot = number / 100;
    int ed = number % 10;

    int result = sot * 10 + ed;
    return result;
}

int randNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randNumber);

Console.WriteLine($"New version of a number {randNumber} is {newNumber}");
*/

/* булиевый метод

bool IsEven(int num)
{
    if(num % 2 ==0)
        return true;
    else
        return false;
}


&& - и
|| - или
*/

// Задача 2. Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

/*
int MaxNum(int number)
{
    int first = number / 10;
    int second = number % 10;

    if(first > second)
        return first;
    else
        return second;
}

int number = new Random().Next(10, 100);
Console.WriteLine(number);
Console.WriteLine(MaxNum(number));
*/

// Задача 3. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому.

/*
bool KratNum(int num1, int num2)
{
    if(num2 % num1 == 0)
        return true;
    else
        return false;
}

Console.Write("Input number1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(KratNum(num1, num2));
*/

// Задача 4. Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.


bool Quad(int num1, int num2)
{
    if(num1 * num1 == num2 || num2 * num2 == num1)
        return true;
    else
        return false;
}

Console.Write("Input number1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Quad(num1, num2));