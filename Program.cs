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
            int maxTryCount = 3;

            while (tryCount < maxTryCount)
            {
                Console.Write("Для доступа введите пароль:\t");
                input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine("Доступ открыт, проходите!");
                    tryCount = maxTryCount;
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
