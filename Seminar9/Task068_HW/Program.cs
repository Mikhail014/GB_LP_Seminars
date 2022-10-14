// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int GetNumAkkerman(int n1, int n2)
{
    if (n1 == 0) return n2 + 1;
    if (n1 > 0 && n2 == 0) return GetNumAkkerman(n1 - 1, 1);
    return GetNumAkkerman(n1 - 1, GetNumAkkerman(n1, n2 - 1));
}

int res = GetNumAkkerman(num1, num2);
System.Console.WriteLine($"A({num1}, {num2}) = {res}");