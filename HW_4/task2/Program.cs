// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("");
Console.WriteLine("*****************************************");
Console.WriteLine("Программа для сложения всех цифр в числе");
Console.WriteLine("*****************************************");
Console.WriteLine("");

// Интерактивный код
// Console.Write("Введите число чтобы узнать сумму его цифр: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// void SumOfNumbsInteract()
// {
//     while (num != 0)
//     {
//         sum += num % 10;
//         num /= 10;
//     }

//     Console.WriteLine("Сумма всех цифр в числе равна: " + sum);
// }

// SumOfNumbsInteract();


// Легкий код
int SumOfNumbsLight(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

int result = SumOfNumbsLight(555);
Console.WriteLine("Сумма всех цифр в числе равна: " + result);