// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

// 645-> 5
// 78->третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int numRead = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (numRead >= 100)
{
    int num = numRead;
    while (num > 999)
    {
        num = num / 10;
    }

    result = num % 10;
    Console.WriteLine("Третья цифра числа " + numRead + " будет " + result);
}
else
{
    Console.WriteLine("У числа " + numRead + " нет третьей цифры");
}