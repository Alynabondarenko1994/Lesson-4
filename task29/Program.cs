/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]
*/

int[] ArrayRandom(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
        arr[i] = rnd.Next(0, 100);
    return arr;
}

void printArray(int[] num)
{
    Console.Write("[");
    for (int i = 0; i < num.Length; i++)
    {
        if (i < num.Length - 1)
            Console.Write(num[i] + ", ");
        else
            Console.Write(num[i] + "]");
    }

}


int[] rnd1 = ArrayRandom(8);
printArray(rnd1);

