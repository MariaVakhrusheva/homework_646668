/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int PrintSum(int startValue, int finishValue, int sum)
{
    sum = startValue;
    if (startValue == finishValue) return sum;
    return sum + PrintSum(startValue + 1, finishValue, sum);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int sum = 0;
int numberM = GetInput("Введите число M: ");
int numberN = GetInput("Введите число N: ");
Console.Write($"M = {numberM}; N = {numberN} -> {PrintSum(numberM, numberN, sum)}");