Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Первая точка. Координата точки X: ");
int coordX1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Первая точка. Координата точки Y: ");
int coordY1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Вторая точка. Координата точки X: ");
int coordX2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Вторая точка. Координата точки Y: ");
int coordY2 = Convert.ToInt32(Console.ReadLine());

double FindDistBetweenPoints(int x1, int y1, int x2, int y2)
{
    int distX = (x2 - x1) * (x2 - x1);
    int distY = (y2 - y1) * (y2 - y1);
    double result = Math.Sqrt(distX + distY); 
    return Math.Round(result, 2, MidpointRounding.ToZero);
}

Console.WriteLine($"Расстояние между заданными точками: {FindDistBetweenPoints(coordX1, coordY1, coordX2, coordY2)}");