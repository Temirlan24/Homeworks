using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Console.WriteLine("Введите сторку: ");
            char input;
            int spaceCount = 0;
            do
            {
                input = Console.ReadKey().KeyChar; 
                if (input == ' ')
                    spaceCount++;
            }
            while (input != '.');

            Console.WriteLine("\nКоличество пробелов = {0}",spaceCount);
            Console.ReadKey();*/

            /*2. string ticket = Console.ReadLine();
             int sumFirstPart = 0, sumSecondPart = 0;

             sumFirstPart = ticket[0] + ticket[1] + ticket[2];
             sumSecondPart = ticket[3] + ticket[4] + ticket[5];
             if (sumFirstPart == sumSecondPart)
             {
                 Console.WriteLine("Этот билет является счастливым!!!");
             }
             else
             {
                 Console.WriteLine("Билет не счастливый!!!");
             }
             Console.ReadKey();*/

            /* 3. string textRegister = Console.ReadLine();
            if (textRegister.First() >= 'a' && textRegister.First() <= 'z')
            {
                Console.WriteLine(textRegister.ToUpper());
            }
            else if(textRegister.First() >= 'A' && textRegister.First() <= 'Z')
            {
                Console.Write(textRegister.ToLower());
            }
            Console.ReadKey(); */
            /* 4 Console.WriteLine("Введите минимальное значение диапазона: ");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальное значение диапазона: ");
            int maxNumber = int.Parse(Console.ReadLine());
            for(int i = minNumber; i <= maxNumber; i++)
            {
                for(int j = 0; j <i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
           */
            /*5. Console.WriteLine("Введите число: ");
            string number = Console.ReadLine();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);

            }
            Console.ReadKey();
            */
        }
    }
}
