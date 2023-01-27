// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("");
Console.WriteLine("*****************************************************************");
Console.WriteLine("Программа сгенерирует и покажет сколько положительных чисел в нем");
Console.WriteLine("*****************************************************************");
Console.WriteLine("");

Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] numb = new int[arraySize];
Console.WriteLine();
GetNewRandomArray(numb);
PrintArray(numb);
Console.WriteLine();
int count = 0;

for (int i = 0; i < numb.Length; i++)
    if (numb[i] % 2 == 0)
        count++;

void GetNewRandomArray(int[] numb)
{
    for (int i = 0; i < numb.Length; i++)
    {
        numb[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] numb)
{
    for (int i = 0; i < numb.Length; i++)
    {

        Console.WriteLine(numb[i] + " ");
    }
}

if (count == 1)
{
    Console.WriteLine("Массив состоит из " + numb.Length + " эл. " + count + " эл. чётный");
}
else
{
    Console.WriteLine("Массив состоит из " + numb.Length + " эл. " + count + " эл. чётные");
}