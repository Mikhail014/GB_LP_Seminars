Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите координаты точки X: ");
int coordX = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты точки Y: ");
int coordY = Convert.ToInt32(Console.ReadLine());

int GetNumberQuarter(int x, int y)
{
    if (x == 0 || y == 0) return 0;
    if (x < 0 && y > 0) return 1;
    if (x > 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    return 4;
}

int coords = GetNumberQuarter(coordX, coordY);

if (coords == 0) Console.WriteLine("X и Y не должны быть равны нулю!");
else Console.WriteLine($"Четверть {coords}");
