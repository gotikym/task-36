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


            Console.WriteLine("для продолжения нажмите enter, для сложения введите - sum, для выхода из программы - exit");
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

                    numbers.Add(GetNumber());

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
