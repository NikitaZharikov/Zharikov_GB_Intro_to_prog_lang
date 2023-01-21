// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом (НЕ использовать число как строку,
// то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ.
// Используем операторы % и /).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int oldValue = number;
int newValue = 0;
int dig = 0;

while (number > 0)
{
    dig = number % 10;
    newValue = newValue * 10 + dig;
    number = number / 10;
}

if (newValue == oldValue)
    Console.WriteLine("Число является палиндромом");

else
    Console.WriteLine("Число не является палиндромом");