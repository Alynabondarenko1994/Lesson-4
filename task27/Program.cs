/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


int GetNumber(string str)
{

    while (true)
    {
        Console.WriteLine(str);
        string? x = Console.ReadLine();

        if (int.TryParse(x, out int num) == false)
        {
            Console.WriteLine("Введено не число");


        }
        else
            return num;
    }
}

void SumDigit(int a)

{

    int a_ = a;
    int result = 0;
    while (a > 0)
    {
        int b = a % 10;
        a = a / 10;
        result = b + result;
    }
    Console.WriteLine("Сумму цифр в числе "+a_ + " равна " + result);

}

int number = GetNumber("Введите число:");
SumDigit(number);
