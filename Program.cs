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
        int sum = 0;

        while (exit == false)
        {
            Console.WriteLine("Для добавления новых чисел введите - 1, для сложения - sum, для выхода из программы - exit");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":

                    numbers.Add(GetNumber());

                    break;

                case "sum":

                    foreach(var number in numbers)
                    {
                        sum += number;
                    }

                    Console.WriteLine("Сумма всех введённых чисел = " + sum);
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

        while(isParse== false)
        {
            Console.WriteLine("Введите число: ");
            string numberUser = Console.ReadLine();

            if(isParse=int.TryParse(numberUser, out int number))
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
}
