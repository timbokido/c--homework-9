// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("введите значение N:");
int n = Convert.ToInt32(Console.ReadLine());
string PrintNum(int start)
{
    if (start == 1)
    {
        return "1";
    }
    return (start + " " + PrintNum(start - 1));
}
Console.WriteLine(PrintNum(n));