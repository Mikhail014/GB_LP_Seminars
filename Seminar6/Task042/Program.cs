Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string ConvertBinNum(int n)
{
    string str = default;
    while (n != 0)
    {
        str += (n % 2).ToString();
        n /= 2;
    }
    char[] chars = str.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);
}

System.Console.WriteLine(ConvertBinNum(num));