// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Координаты точки A: ");
Console.Write("X: ");
int axCoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ayCoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int azCoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координаты точки B: ");
Console.Write("X: ");
int bxCoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int byCoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int bzCoord = Convert.ToInt32(Console.ReadLine());

double FindDistBetweenTwoPoints(int ax, int ay, int az, int bx, int by, int bz)
{
    int quadX = (bx - ax) * (bx - ax);
    int quadY = (by - ay) * (by - ay);
    int quadZ = (bz - az) * (bz - az);
    double dist = Math.Sqrt(quadX + quadY + quadZ);
    return Math.Round(dist, 2, MidpointRounding.ToZero);
}

Console.WriteLine("Расстояние между точками A и B: ");
Console.Write(FindDistBetweenTwoPoints(axCoord, ayCoord, azCoord, bxCoord, byCoord, bzCoord));