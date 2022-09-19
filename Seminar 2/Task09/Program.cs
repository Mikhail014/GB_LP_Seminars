Console.OutputEncoding = System.Text.Encoding.UTF8;

int randNum = new Random().Next(10, 100);




// if (Digit1 > Digit2) Console.WriteLine($"Наибольшая цифра числа: {Digit1}");
// else if (Digit1 == Digit2) Console.WriteLine("Цифры одинаковые");
// else Console.WriteLine($"Наибольшая цифра числа: {Digit2}");


// int max = Digit1 > Digit2 ? Digit1 : Digit2; // тернарное выражение

int MaxDigit(int num)
{
    Console.WriteLine($"Случайные числа из отрезка 10 -> 99: {num}");

    int Digit1 = num / 10;
    int Digit2 = num % 10;

    if (Digit1 == Digit2) return -1;

    return Digit1 > Digit2 ? Digit1 : Digit2;
}

bool IsEqualDigits(int num1, int num2)
{
    return num1 == num2;
}

int md = MaxDigit(randNum);

string result = md != -1 ? md.ToString() : "Цифры одинаковые"; 

Console.WriteLine(result);