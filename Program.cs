using System;
using System.Collections.Generic;

internal class Program
{
    const string Summ = "sum";
    const string Exit = "exit";

    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        SumEnteredNumbers(numbers);
    }

    static void SumEnteredNumbers(List<int> numbers)
    {
        bool isExit = false;

        while (isExit == false)
        {
            Console.WriteLine("Введите число, которое хотите добавить.   Для сложения введите - " + Summ + ", для выхода из программы - " + Exit);
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case Summ:

                    Sum(numbers);

                    break;

                case Exit:

                    isExit = true;

                    break;

                default:

                    numbers.Add(GetNumber(userChoice));

                    break;
            }
        }
    }

    static int GetNumber(string userChoice)
    {
        int numberForReturn = 0;

        if (int.TryParse(userChoice, out int number))
        {
            numberForReturn = number;
        }
        else
        {
            Console.WriteLine("Вы не корректно ввели число");
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
