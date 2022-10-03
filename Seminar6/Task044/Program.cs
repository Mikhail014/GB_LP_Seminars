Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void PrintFibonacci(int n)
{

    int num1 = default;
    int num2 = default;
    int f = default;

    for (int i = 0; i < n; i++)
    {

        if (i == 0) 
        {
            num1 = 0;
            num2 = 0;
        }
        else if (i == 1 || i == 2)
        {
            num1 = 0;
            num2 = 1;
        }
        else
        {
            num1 = num2;
            num2 = f;
        }
        
        
        f = num1 + num2;
        Console.Write($"{f} ");
        
    }
}

PrintFibonacci(num);