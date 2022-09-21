Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число от 1 до 7 включительно: ");
int number = Convert.ToInt32(Console.ReadLine());

bool IsDayOff(int num)
{
    return num > 5 && num < 8;
}

if (IsDayOff(number))
{
    Console.WriteLine($"Число {number}. Этот день является выходным!");
}
else
{
    Console.WriteLine(number < 1 || number > 7 ? "Пожалуйста, введите число от 1 до 7 включительно!" : $"Число {number}. Это будний день!");
}