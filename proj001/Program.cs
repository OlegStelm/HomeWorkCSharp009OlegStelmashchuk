/*  **Задача 64**
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"   */

int n;
Console.WriteLine("Enter the number: ");
int.TryParse(Console.ReadLine()!, out n);
PrintNumbers(n, 1);
void PrintNumbers(int first, int last)
{
    if (first <= last)
        Console.Write($"{first} ");
    else
    {
        Console.Write($"{first} ");
        PrintNumbers(first - 1, last);
    }
}
