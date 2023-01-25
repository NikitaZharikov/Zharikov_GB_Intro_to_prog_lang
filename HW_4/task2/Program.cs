// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число чтобы узнать сумму его цифр: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

void SumOfNumbs()
{
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }

    Console.WriteLine("Сумма всех цифр в числе равна: " + sum);
}

SumOfNumbs();