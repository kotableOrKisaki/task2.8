using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "meow";
            string input;
            int tryCount = 0;

            while (tryCount < 3)
            {
                Console.Write("Для доступа введите пароль:\t");
                input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine("Доступ открыт, проходите!");
                    break;
                }
                else
                {
                    Console.WriteLine("А у вас доступа то и нет!");
                    tryCount++;
                }
            }

            Console.WriteLine("Охрана проводит вас на выход!");
        }
    }
}
