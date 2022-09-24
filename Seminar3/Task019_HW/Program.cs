// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool IsPalindrome(int n)
{
    int n1 = n / 1000;
    int n2 = n % 100;
    int n2Reverse = (n2 % 10 * 10) + (n2 / 10);
    if (n1 == n2Reverse) return true;
    return false;
}

if (num < 10000 || num > 99999) Console.WriteLine("Ошибка! Введите пятизначное число!");
else Console.WriteLine(IsPalindrome(num) ? $"Число {num} является палиндромом" : $"Число {num} не является палиндромом");