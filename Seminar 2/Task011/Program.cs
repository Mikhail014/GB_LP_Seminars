Console.OutputEncoding = System.Text.Encoding.UTF8;

int randNum = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерированное число: {randNum}");

int func1(int num)
{
    int Digit1 = (randNum / 100) * 10;
    int Digit2 = randNum % 10; 
    return Digit1 + Digit2;
}

Console.Write("Результат: ");
Console.WriteLine(func1(randNum));