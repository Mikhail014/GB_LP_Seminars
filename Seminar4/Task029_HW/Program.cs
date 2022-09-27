// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Количество элементов в массиве: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Минимальное число: ");
int minNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Максимальное число: ");
int maxMax = Convert.ToInt32(Console.ReadLine());

int[] GetArrayOfNumbers(int len, int min, int max)
{
    if (len < 1) return new int[0];
    int[] array = new int[len];
    Random r = new Random();
    for (int i = 0; i < len; i++)
    {
        array[i] = r.Next(min, max + 1);
    }
    return array;
}

int[] arrayNums = GetArrayOfNumbers(length, minNum, maxMax);
string res = default;

for (int i = 0; i < length; i++)
{  
    if (i == 0) res += "[";
    if (i < length - 1) res += $"{arrayNums[i]}, ";
    else res += $"{arrayNums[length - 1]}]";
}

if (minNum < maxMax && length > 0) Console.WriteLine($"Массив: {res}");
else if (arrayNums.Length == 0) Console.WriteLine("Число элементов в массиве должно быть больше нуля");
else Console.WriteLine("Первое число должно быть меньше второго");