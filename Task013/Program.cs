/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
//int getThreeNumber (int number)
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

int findThirdNumber(int number, int count) //Нахождение третьего числа если есть
{
    if ((number > 100) || (number < -99))
    {
        if (number < 0)
            number *= -1;
        int ostatok = 1;
        int result = 1;
        for (int i = 0; i < count - 2; i++)
        {
            ostatok *= 10;
        }
        for (int i = 0; i < count - 3; i++)
        {
            result *= 10;
        }
        number %= ostatok;
        number /= result;
        return number;
    }
    else
    {
        Console.WriteLine("Третей цифры нет!");
        return 404;
    }
}

Console.Write("Введите число: ");
string input = Console.ReadLine() ?? "";
if (checkInput(input)) //Если данные введены корректно
{
    int number = int.Parse(input);
    int count;
    if (number < 0)
        count = input.Length - 1;
    else
        count = input.Length;
    if (findThirdNumber(number, count) != 404) // Если нет ошибки
    {
        Console.WriteLine($"Третяя цифра числа {input} это - {findThirdNumber(number, count)}");
    }
}