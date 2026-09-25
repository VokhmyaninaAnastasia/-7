//****************************************************************************
//*Практическая работа №4                                                    *
//* Выполнила: Вохмянина А.Р., группа 2-ИСП                                  *
//* Задание: составление программы циклической структуры: циклс с параметром *
//****************************************************************************
using System;

namespace работа_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Практическая работа 7");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                Console.Write("Здравствуйте! Введите стоимость телефона N: ");
                int N = int.Parse(Console.ReadLine());

                Console.Write("Введите сумму, которую Мария откладывает в день K: ");
                int K = int.Parse(Console.ReadLine());
                int sum = 0;
                int days = 0;
                for (int day = 1; sum < N; day++)
                {
                    days++;
                    // 6-й день - суббота
                    if (day % 7 != 6)
                    {
                        sum += K;
                    }
                }
                Console.WriteLine($"Мария накопит нужную сумму за {days} дней");
                Console.WriteLine($"Накопленная сумма: {sum} рублей");
            }
            catch
            {
                Console.WriteLine("Ошибка! Введите целые числа.");
            }
            Console.ReadKey();
        }
    }
}


