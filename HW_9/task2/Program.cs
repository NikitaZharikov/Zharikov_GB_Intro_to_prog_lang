// Задача 66:
// Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

Console.WriteLine("");
Console.WriteLine("#################################");
Console.WriteLine("Программа найдёт сумму натуральных");
Console.WriteLine("элементов в промежутке от M до N");
Console.WriteLine("#################################");
Console.WriteLine("");

int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}