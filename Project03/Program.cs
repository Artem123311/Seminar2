using System;

class Program
{
public static int Main()
    {
        Console.Write("Введите число : ");
        int num = int.Parse(Console.ReadLine ());
        int i = 0;
        while(num > 0)
        {
        i++;
        num/= 10;
        }
    Console.WriteLine("Количество цифр введенного числа : {0}", i);
    Console.ReadKey();
    return 0;
    }
}