// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29 (возможно что в примере m и n перепутаны местами)


Console.WriteLine("Введите два положительных числа: M и N.");
Console.Write("Введите число M : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({m}, {n}) = {Aсkerman(m, n)}");


int Aсkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Aсkerman(m - 1, 1);
    else
        return Aсkerman(m - 1, Aсkerman(m, n - 1));
}
