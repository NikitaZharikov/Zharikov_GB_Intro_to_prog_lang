// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double lenghtXYZ(int x1, int x2, int x3, int y1, int y2, int y3)
{
    double xres = (x1 - x2 - x3) * (x1 - x2 - x3);
    double yres = (y1 - y2 - y3) * (y1 - y2 - y3);
    double lrez = Math.Sqrt(xres + yres);
    return lrez;
}
Console.WriteLine("Узнайте расстояние между точками в 3D пространстве!");
Console.WriteLine("Введите координаты точки по оси X");
Console.Write("Первое значение координаты точки x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе значение координаты точки x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье значение координаты точки x: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите координаты точки по оси Y");
Console.Write("Первое значение координаты точки y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе значение координаты точки y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье значение координаты точки y: ");
int y3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Расстояние между точками равно " + Math.Round(lenghtXYZ(x1, x2, x3, y1, y2, y3), 2));