// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("");
Console.WriteLine("*****************************************************************************");
Console.WriteLine("Программа сгенерирует и покажет сумму элементов, стоящих на нечётных позициях");
Console.WriteLine("*****************************************************************************");
Console.WriteLine("");

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numb = new int[size];
Console.WriteLine();
GetNewRandomArray(numb);
PrintArray(numb);
Console.WriteLine();
int sum = 0;

for (int i = 0; i < numb.Length; i += 2)
    sum = sum + numb[i];

void GetNewRandomArray(int[] numb)
{
    for (int i = 0; i < numb.Length; i++)
    {
        numb[i] = new Random().Next(-1000, 1000);
    }
}
void PrintArray(int[] numb)
{
    for (int i = 0; i < numb.Length; i++)
    {
        Console.WriteLine();
        Console.WriteLine(numb[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Cумма элементов на нечётных позициях = " + sum);