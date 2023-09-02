// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("введите значение M и N:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int sum=0;
int Sum(int start, int end)
{
    if (start==end)
    {
        sum+=start;
        return sum;
    }
    sum+=start;
    return Sum(start+1, n);
}
Console.WriteLine(Sum(m, n));