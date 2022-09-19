Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Multiple(int num1, int num2)
{
    return num1 % num2;
}


string result = Multiple(num1, num2) == 0 ? $"Числа {num1} и {num2} кратны" : $"Числа {num1} и {num2} некратны. Остаток: {num1 & num2}";

Console.WriteLine(result);