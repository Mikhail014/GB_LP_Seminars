// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите положительное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральную степень: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int NumberToPower(int n1, int n2)
{
    if (num2 <= 0) return -1;
    int res = 1;
    for (int i = 0; i < n2; i++) res *= n1;
    return res;
}

int ntp = NumberToPower(num1, num2);

if (ntp != -1) Console.WriteLine($"Число {num1} в степени {num2} равно {ntp}");
else Console.WriteLine("Число необходимо возводить в натуральную степень!");