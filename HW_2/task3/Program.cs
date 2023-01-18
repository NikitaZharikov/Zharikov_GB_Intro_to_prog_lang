// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите порядковый номер дня недели: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Будний день (понедельник)");
        break;
    case 2:
        Console.WriteLine("Будний день (вторник)");
        break;
    case 3:
        Console.WriteLine("Будний день (среда)");
        break;
    case 4:
        Console.WriteLine("Будний день (четверг)");
        break;
    case 5:
        Console.WriteLine("Будний день (пятница)");
        break;
    case 6:
        Console.WriteLine("Выходной день (суббота)");
        break;
    case 7:
        Console.WriteLine("Выходной день (воскресенье)");
        break;
    default:
        Console.WriteLine("Что то похло нет так)");
        break;
}