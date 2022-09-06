// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

 Console.Write("Введите число M : ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите число N : ");
 int n = Convert.ToInt32(Console.ReadLine());
		
        int SummNatElement(int m, int n)
		{
			int first = m;
			int last = n;
			if(m > n)
			{
				first = n;
				last = m;
			}
			return (last - first + 1)*(first + last)/2; 
		}
		Console.WriteLine("Cумма натуральных элементов в промежутке от M до N : ");
		Console.WriteLine(SummNatElement(m, n));
