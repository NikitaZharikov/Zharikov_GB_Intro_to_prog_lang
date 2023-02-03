﻿// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("");
Console.WriteLine("*************************************************");
Console.WriteLine("Программа покажет сколько чисел больше 0 вы ввели");
Console.WriteLine("*************************************************");
Console.WriteLine("");

Console.Write("Введите числа через запятую: ");
int[] nums = StringToNum(Console.ReadLine());
PrintArray(nums);
int sum = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > 0)
    {
        sum++;
    }
}

Console.WriteLine("Количество значений больше 0 = " + sum);

int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int[count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input[i] != ',')
        {
            if (i != input.Length - 1)
            {
                temp += input[i].ToString();
                i++;
            }
            else
            {
                temp += input[i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}