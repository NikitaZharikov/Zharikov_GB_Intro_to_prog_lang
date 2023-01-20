// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

// 645-> 5
// 78->третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result1 = num % 10;
int result2 = (num / 10) % 10;
int result3 = (num / 100) % 10;

if (num < 100)
{
    Console.WriteLine("У числа " + num + " нет третьей цифры");
}
else if (num >= 100 && num < 1000)
{
    Console.WriteLine("Третья цифра числа " + num + " будет " + result1);
}
else if (num > 1000 && num < 10000)
{
    Console.WriteLine("Третья цифра числа " + num + " будет " + result2);
}
else
{
    Console.WriteLine("Третья цифра числа " + num + " будет " + result3);
}