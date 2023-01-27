// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("Программа сгенерирует и покажет разницу между максимальным и минимальным элементов массива");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("");

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numb = new int[size];
Console.WriteLine();
GetNewRandomArray(numb);
PrintArray(numb);
Console.WriteLine();
int minEl = Int32.MaxValue;
int maxEl = Int32.MinValue;

for (int i = 0; i < numb.Length; i++)
{
    if (numb[i] > maxEl)
    {
        maxEl = numb[i];
    }
    if (numb[i] < minEl)
    {
        minEl = numb[i];
    }
}

void GetNewRandomArray(int[] numb)
{
    for (int i = 0; i < numb.Length; i++)
    {
        numb[i] = new Random().Next(1, 100);
    }
}
void PrintArray(int[] numb)
{
    for (int i = 0; i < numb.Length; i++)
    {
        Console.WriteLine(numb[i] + " ");
    }

}

Console.WriteLine("Максимальное значение = " + maxEl);
Console.WriteLine("Минимальное значение = " + minEl);
Console.WriteLine("Разница между максимальным и минимальным элементами = " + (maxEl - minEl));