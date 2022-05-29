/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
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

void Degree(int a, int b)

{
    int[] arrayA = new int[b];
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        arrayA[i] = a;
        result = result * arrayA[i];
    }
    Console.WriteLine(a + "," + b + "->" + result);

}

int x = GetNumber("Введите первое число:");
int y = GetNumber("Введите второе число:");

Degree(x, y);
