/* 
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void PrintNaturalNumbers(int n)
{
    int number = 1;
    if (n == number)
    {
        Console.Write(n);
    }
    else
    {
        Console.Write(n);
        PrintNaturalNumbers(n - 1);
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumbers(number);

//Другой способ решения рекурсией)
