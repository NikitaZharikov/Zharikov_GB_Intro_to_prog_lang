// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]

Console.WriteLine("");
Console.WriteLine("*****************************************");
Console.WriteLine("Программа ввода и вывода массива");
Console.WriteLine("*****************************************");
Console.WriteLine("");

Console.Write("Введите размер массива: ");
int arrayCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrayCount];

void ArrayView()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент №" + (i + 1) + " ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Вывод массива:");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

ArrayView();