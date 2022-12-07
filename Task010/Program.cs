/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
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

int findSecondNumber(int number) //Нахождение второго числа если есть
{
    if ((number > -1000) && (number < -99) || (number > 99) && (number < 1000))
    {
        number %= 100;
        number /= 10;
        if (number < 0)
            number *= -1;
        return number;
    }
    else
    {
        Console.WriteLine("Число не трехзначное!");
        return 404; //Ошибка
    }
}

Console.Write("Введите трехзначное число: ");
string input = Console.ReadLine() ?? "";
if (checkInput(input)) //Если данные введены корректно
{
    int number = int.Parse(input);
    if (findSecondNumber(number) != 404) // Если нет ошибки
    {
        Console.WriteLine($"Вторая цифра числа {input} это - {findSecondNumber(number)}"); 
    }
}

