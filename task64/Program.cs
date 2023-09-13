// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine(PrintNum(8, 1));

string PrintNum(int N, int end)
{
    if (N == end)
    {
        return N.ToString();
    }
    return N + ", " + PrintNum(N - 1, end);
}
