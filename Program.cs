
using System;

namespace TaskJunior2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameUser;
            string middleLine;
            string frame = "";

            char symbolInput;

            int someString;

            Console.WriteLine("Добро пожаловать, в обработку в красивой форме вашего Имени.");

            Console.Write("Введите ваше замечательное Имя: ");
            nameUser = Console.ReadLine();

            Console.Write("Введите символ: ");
            symbolInput = Convert.ToChar(Console.ReadLine());

            someString = nameUser.Length;
            middleLine = symbolInput + nameUser + symbolInput;

            for (int i = 0; i < (someString + 2); i++)
            {
                frame += symbolInput;
            }

            Console.Write(frame);
            Console.Write("\n" + middleLine + "\n");
            Console.Write(frame);
        }
    }
}
