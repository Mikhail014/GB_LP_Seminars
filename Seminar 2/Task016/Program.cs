Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

string CheckQuad(int num1, int num2)
{
    if (num1 > num2 && num2 * num2 == num1) return $"Число {num1} является квадратом числа {num2}";
    else if (num1 < num2 && num1 * num1 == num2) return $"Число {num2} является квадратом числа {num1}";
    return $"Число {num1} не является квадратом числа {num2}";
}

Console.WriteLine(CheckQuad(num1, num2));