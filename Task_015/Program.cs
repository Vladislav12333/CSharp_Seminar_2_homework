// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//Первый вариант решения задачи
Console.Write("Введите номер дня недели: ");
int dayNumber = int.Parse(Console.ReadLine());

switch (dayNumber)
{
    case 1:
        Console.WriteLine("Это понедельник, рабочий день.");
        break;
    case 2:
        Console.WriteLine("Это вторник, рабочий день.");
        break;
    case 3:
        Console.WriteLine("Это среда, рабочий день.");
        break;
    case 4:
        Console.WriteLine("Это четверг, рабочий день.");
        break;
    case 5:
        Console.WriteLine("Это пятница, рабочий день.");
        break;
    case 6:
        Console.WriteLine("Это суббота, выходной день.");
        break;
    case 7:
        Console.WriteLine("Это воскресенье, выходной день.");
        break;
    default:
        Console.WriteLine("Нет такого дня недели.");
        break;
}