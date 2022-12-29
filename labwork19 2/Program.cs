using System;

class Program
{
    static void Main()
    {
        Console.Write("n = "); //задаем катеты
        int n = int.Parse(Console.ReadLine()); //ввод числа с консоли
        for (int i = 0; i < n; i++) //1 катет
        {
            for (int j = 0; j <= i; j++)//2 катет
            {
                Console.Write("m"); //символы, из которых состоит прямоугольный треугольник
            }
            Console.WriteLine(); //переход на следующую строку
        }
        Console.ReadLine();//программа ждет нажатия клавиши для завершения работы

    }
}