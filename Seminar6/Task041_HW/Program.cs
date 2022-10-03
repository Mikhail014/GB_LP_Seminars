// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Количество чисел: ");
int count = Convert.ToInt32(Console.ReadLine());

int GetAmountPositiveNums(int count)
{
    if (count <= 0) return -1;
    int positiveNums = default;
    for (int i = 1; i <= count; i++)
    {
        Console.Write($"Введите {i}-е число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) positiveNums++;
    }
    return positiveNums;
}

int res = GetAmountPositiveNums(count);
Console.WriteLine(res != -1 ? $"Количество положительных чисел: {res}" : "Введите положительное число!");