/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
bool checkInput(string input) //Функция проверки корректности введенных данных
{
    int number;
    if (int.TryParse(input, out number))
    {
        return true;
    }
    else
    {
        Console.WriteLine("Данные введены некорректно!");
        return false;
    }
}

string getDayOfWeek(int number) //Функция указывает какой день выбран
{
    if ((number > 0) && (number < 8))
    {
        string[,] daysOfWeek = new string[2, 7] {{"1", "2", "3", "4", "5", "6", "7"},
        {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"}};
        string dayOfWeek = "";
        for (int i = 0; i < 7; i++)
        {
            if (daysOfWeek[0, i] == Convert.ToString(number))
            {
                dayOfWeek = daysOfWeek[1, i];
            }
        }
        return dayOfWeek;
    }
    else
    {
        return "Такого дня недели нет";
    }
}

bool isItWeekend(string day) //Функция определяет выходной ли сегодня
{
    if ((day == "Суббота") || (day == "Воскресенье"))
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите номер дня недели: ");
string input = Console.ReadLine() ?? "";
if (checkInput(input)) //Если данные введены корректно
{
    int number = int.Parse(input);
    if (getDayOfWeek(number) != "Такого дня недели нет")
    {
        if (isItWeekend(getDayOfWeek(number)))
        {
            Console.WriteLine($"{getDayOfWeek(number)} - выходной день");
        }
        else
        {
            Console.WriteLine($"{getDayOfWeek(number)} - рабочий день");
        }
    }
    else
    {
        Console.WriteLine(getDayOfWeek(number));
    }
}
