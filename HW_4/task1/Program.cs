// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("");
Console.WriteLine("*****************************************");
Console.WriteLine("Программа для возведения числа в степень");
Console.WriteLine("*****************************************");
Console.WriteLine("");

Console.Write("Введите число которое хотите возвести в степень: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень в которую хотите возвести: ");
int numberToPower = Convert.ToInt32(Console.ReadLine());


void NumPowInteract()
{
    int result = number;
    for (int i = 1; i < numberToPower; i++)
    {
        result *= number;
    }

    Console.WriteLine("Возведение числа " + number + " в степень " + numberToPower + " равно: " + result);
}

NumPowInteract();

// int NumPowLight(int number, int numberToPower)
// {
//     int result = number;
//     for (int i = 1; i < numberToPower; i++)
//     {
//         result *= number;
//     }
//     return result;
// }

// int finalResult = NumPowLight(5, 5);
// Console.WriteLine(finalResult);