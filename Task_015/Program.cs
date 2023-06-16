// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//Второй вариант решения задачи
Console.Write("Введи цифру деня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void DayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Да, этот день выходной");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Такого дня недели не существует");
    }
    else Console.WriteLine("Нет, этот день не выходной");
}
DayOfTheWeek(dayNumber);
