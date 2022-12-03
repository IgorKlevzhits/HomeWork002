/*
адача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Write("Введите трехзначное число: ");
string input = Console.ReadLine() ?? "";
int number;
if(int.TryParse(input,out number))
{
    if ((number < 100) || (number > 999))
    {
        Console.WriteLine("Число не трехзначное!");
    }
    else
    {
        Console.WriteLine("Ок!");
    }
}
else
{
    Console.WriteLine("Данные введены некорректно!");
}
