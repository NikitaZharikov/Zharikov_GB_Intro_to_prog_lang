// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

// 645-> 5
// 78->третьей цифры нет
// 32679 -> 6

Console.Write("Введите трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int result = num1 % 100 % 10;
if (num1 < 1 || num1 < 100)
{
    Console.WriteLine("Число " + num1 + " не подходит");
}
else
{
    Console.WriteLine("Третья цифра числа " + num1 + " будет " + result);
};