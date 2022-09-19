Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool CheckMultiple(int num)
{
    return num % 7 == 0 && num % 23 == 0 ? true : false; 
}

string result = CheckMultiple(num) ? $"Число {num} кратно одновременно 7 и 23" : $"Число {num} некратно одновременно 7 и 23";

Console.WriteLine(result);