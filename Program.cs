using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        MemorizeAndSumNumbers(numbers);
    }

    static void MemorizeAndSumNumbers(List<int> numbers)
    {
        bool exit = false;

        while (exit == false)
        {
            numbers.Add(GetNumber());

            Console.WriteLine("для продолжения нажмите enter, для сложения введите - sum, для выхода из программы - exit");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "sum":

                    Sum(numbers);

                    break;

                case "exit":

                    exit = true;

                    break;
            }
        }
    }

    static int GetNumber()
    {
        bool isParse = false;
        int numberForReturn = 0;

        while (isParse == false)
        {
            Console.WriteLine("Введите число: ");
            string numberUser = Console.ReadLine();

            if (isParse = int.TryParse(numberUser, out int number))
            {
                isParse = true;
            }
            else
            {
                Console.WriteLine("Вы не корректно ввели число, попробуйте ввести число без точек, запятых, скобочек и букв");
            }

            numberForReturn = number;
        }

        return numberForReturn;
    }

    static void Sum(List<int> numbers)
    {
        int sum = 0;

        foreach (var number in numbers)
        {
            sum += number;
        }

        Console.WriteLine("Сумма всех введённых чисел = " + sum);
    }
}
