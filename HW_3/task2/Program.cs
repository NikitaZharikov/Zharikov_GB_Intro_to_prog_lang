// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double lenghtBetweenDots(int dot_AX, int dot_AY, int dot_AZ, int dot_BX, int dot_BY, int dot_BZ)
{
    double resX = Math.Pow((dot_BX - dot_AX), 2);
    double resY = Math.Pow((dot_BY - dot_AY), 2);
    double resZ = Math.Pow((dot_BZ - dot_AZ), 2);
    double finalResult = Math.Sqrt((resX + resY + resZ));
    return finalResult;
}

Console.WriteLine("Узнайте расстояние между точками A и B в 3D пространстве!");
Console.WriteLine("Введите координаты точки A");
Console.Write("Координаты точки A по оси X: ");
int dot_AX = Convert.ToInt32(Console.ReadLine());
Console.Write("Координаты точки B по оси Y: ");
int dot_AY = Convert.ToInt32(Console.ReadLine());
Console.Write("Координаты точки B по оси Z: ");
int dot_AZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите координаты точки B");
Console.Write("Координаты точки B по оси X: ");
int dot_BX = Convert.ToInt32(Console.ReadLine());
Console.Write("Координаты точки B по оси Y: ");
int dot_BY = Convert.ToInt32(Console.ReadLine());
Console.Write("Координаты точки B по оси Z: ");
int dot_BZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Расстояние между точками равно " + Math.Round(lenghtBetweenDots(dot_AX, dot_AY, dot_AZ, dot_BX, dot_BY, dot_BZ), 2));