Console.OutputEncoding = System.Text.Encoding.UTF8;

int[] GetArrayBin()
{
    int[] binNums = new int[8];
    for (int i = 0; i < binNums.Length; i++)
    {
        binNums[i] = new Random().Next(0, 2);
    }
    return binNums;
}

int[] arrayNums = GetArrayBin();
string res = default;
int length = arrayNums.Length;

for (int i = 0; i < arrayNums.Length; i++)
{  
    if (i == 0) res += "[";
    if (i < length - 1) res += $"{arrayNums[i]}, ";
    else res += $"{arrayNums[length - 1]}]";
}

System.Console.WriteLine(res);