// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("введите числа M и N");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int Aker(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Aker(m - 1, 1);
    else
        return Aker(m - 1, Aker(m, n - 1));
}
Console.WriteLine(Aker(m, n));