/*  **Задача 66**
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int m, n;
Console.WriteLine("Enter the number 'm': ");
int.TryParse(Console.ReadLine()!, out m);
Console.WriteLine("Enter the number 'n': ");
int.TryParse(Console.ReadLine()!, out n);
Console.WriteLine();
int sumFor = 0;
int m1 = m;
int n1 = n;
if (n > m)
{
    for (int i = m; i <= n; i++)
    {
        sumFor += m;
        m++;
    }
    Console.WriteLine($"{sumFor}");
    Console.WriteLine($"{SumNumbers(m1, n1)}");
}
else
{
    for (int i = n; i <= m; i++)
    {
        sumFor += n;
        n++;
    }
    Console.WriteLine($"{sumFor}");
    Console.WriteLine($"{SumNumbersReverse(n1, m1)}");
}
int SumNumbers(int left, int right)
{
    if (left >= right)
        return left;
    return left + SumNumbers(left + 1, right);
}

int SumNumbersReverse(int left, int right)
{
    if (left >= right)
        return left;
    return left + SumNumbers(left + 1, right);
}
