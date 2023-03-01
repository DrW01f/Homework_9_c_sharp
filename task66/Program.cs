/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int Sum(int m, int n)
{
    if (n == m) return m;
    else return n + Sum(m, n-1);
}

void Main()
{
    Console.Write("Введите первый элемент: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите второй элемент: ");
    int n = int.Parse(Console.ReadLine()!);
    int result = Sum(m, n);
    Console.Write($"Сумма равна: {result}");
}

Main();