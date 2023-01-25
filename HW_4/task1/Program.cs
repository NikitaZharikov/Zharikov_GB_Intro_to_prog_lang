// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число которое хотите возвести в степень: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень в которую хотите возвести: ");
double numberToPower = Convert.ToDouble(Console.ReadLine());
double result = number;

void NumPow()
{
    for (int i = 0; i < numberToPower; i++)
    {
        result *= number;
    }

    Console.WriteLine("Возведение числа " + number + " в степень " + numberToPower + " равно: " + result);
}

NumPow();


