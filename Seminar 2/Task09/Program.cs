Console.OutputEncoding = System.Text.Encoding.UTF8;

int randNum = new Random().Next(10, 100);

Console.WriteLine($"Случайные числа из отрезка 10 -> 99: {randNum}");

int Digit1 = randNum / 10;
int Digit2 = randNum % 10;

if (Digit1 > Digit2) Console.WriteLine($"Наибольшая цифра числа: {Digit1}");
else if (Digit1 == Digit2) Console.WriteLine("Цифры одинаковые");
else Console.WriteLine($"Наибольшая цифра числа: {Digit2}");


int max = Digit1 > Digit2 ? Digit1 : Digit2;