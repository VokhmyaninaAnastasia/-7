//****************************************************************************
//*Практическая работа №7                                                    *
//* Выполнила: Вохмянина А.Р., группа 2-ИСП                                  *
//* Задание: составление программы циклической структуры: цикл  с параметром *
//****************************************************************************
using System;

namespace работа_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Практическая работа 7.";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                Console.Write("Здравствуйте! Введите стоимость телефона N: ");
                int N = Int32.Parse(Console.ReadLine());

                Console.Write("Введите сумму, которую Мария откладывает в день K: ");
                int K = Int32.Parse(Console.ReadLine());
                int sum = 0;
                int days = 0;
                int weekDay = 1; // 1 - понедельник
                for (int day = 1; sum < N; day++)
                {
                    days++;
                    if (weekDay % 7 != 6) // не суббота
                    {
                        sum += K;
                    }
                }
                Console.WriteLine($"Мария накопит нужную сумму за {days} дней");
                Console.WriteLine($"Накопленная сумма: {sum} рублей");
            }
            catch (FormatException fex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка!" + fex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (StackOverflowException soex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка!" + soex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Что-то пошло не так. Ошибка: " + e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ReadKey();
        }
    }
}


