Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool CheckQuad(int num1, int num2)
{
    return num1 * num1 == num2;
}

string result = CheckQuad(num1, num2) ? $"Число {num2} является квадратом числа {num1}" : $"Число {num2} не является квадратом числа {num1}";

Console.WriteLine(result);