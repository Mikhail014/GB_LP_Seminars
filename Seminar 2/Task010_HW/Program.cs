Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondNum(int num)
{
    if (num < 100 || num > 999) return -1;
    return Math.Abs((num / 10) % 10);
}

if (SecondNum(number) != -1)
{
    Console.WriteLine($"Вторая цифра в трехзначном числе: {SecondNum(number)}");
}
else
{
    Console.WriteLine("Ошибка! Введите трехзначное число!");
}