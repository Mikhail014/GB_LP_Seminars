// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void GetNaturalNumbers(int n)
{
    if (n == 0) return;
    Console.Write($"{n} ");
    GetNaturalNumbers(n - 1);
}

Console.Write("Вывод: ");
GetNaturalNumbers(num);