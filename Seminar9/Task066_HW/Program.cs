// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int GetSumOfNaturalNumbers(int n1, int n2)
{
    if (n2 > n1) return n2 + GetSumOfNaturalNumbers(n1, n2 - 1);
    if (n2 < n1) return n1 + GetSumOfNaturalNumbers(n1 - 1, n2);
    return n1;
}

int res = GetSumOfNaturalNumbers(num1, num2);
System.Console.WriteLine($"Сумма натуральных чисел в промежутке от {num1} до {num2} равна {res}");