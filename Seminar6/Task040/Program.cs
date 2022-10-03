Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Первая сторона треугольника: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Вторая сторона треугольника: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Третья сторона треугольника: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool IsCheckTriangle(int n1, int n2, int n3)
{
    if (n1 < n2 + n3 && n2 < n1 + n2 && n3 < n1 + n2) return true;
    return false; 
}

bool res = IsCheckTriangle(num1, num2, num3);

System.Console.WriteLine(res ? "Треугольник может существовать" : "Треугольник не может существовать");