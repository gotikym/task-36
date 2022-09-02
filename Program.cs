using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        OperateEnteredNumbers(numbers);
    }

    static void OperateEnteredNumbers(List<int> numbers)
    {
        const string Summ = "sum";
        const string Exit = "exit";
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

                    AddNumber(numbers, userChoice);

                    break;
            }
        }
    }

    static void AddNumber(List<int> numbers, string userChoice)
    {
        if (int.TryParse(userChoice, out int number))
        {
            numbers.Add(number);
        }
        else
        {
            Console.WriteLine("Вы не корректно ввели число");
        }
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
