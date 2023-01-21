// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string numCubes(int num)
{
    int i = 2;
    string cubes = "1";
    while (i <= num)
    {
        cubes = cubes + "," + Convert.ToString(i * i * i);
        i++;
    }
    return cubes;
}

Console.Write("Введите число чтобы узать таблицу кубов от 1 до введенного числа: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0)
{
    Console.WriteLine("Введено неверное число!");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Таблица кубов");
    Console.WriteLine(numCubes(num));
}