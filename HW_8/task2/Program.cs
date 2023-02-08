// Задача 56:
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

Console.WriteLine("");
Console.WriteLine("*************************************************************");
Console.WriteLine("Программа будет находить строку с наименьшей суммой элементов");
Console.WriteLine("*************************************************************");
Console.WriteLine("");

Console.Write("Введите размер квадратного массива: ");
int arrayVol = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[arrayVol, arrayVol];
FillArrayRandomNumbers(nums);
Console.WriteLine("");
PrintArray(nums);
Console.WriteLine("");
int minSum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < nums.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        sum = sum + nums[i, j];
    }
    if (sum < minSum)
    {
        minSum = sum;
        indexLine++;
    }
}

Console.WriteLine("Строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minSum));

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}