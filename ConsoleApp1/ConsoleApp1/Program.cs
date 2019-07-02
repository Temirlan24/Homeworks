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

            /* 1 int number1 = 45, number2 = 12, number3 = 56;
             Console.WriteLine("{0} {1} {2}", number1, number2, number3);

             Console.ReadKey();
             */

             //2
            int number1 = 5, number2 = 10, number3 = 21;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.ReadKey();
 
            /*3. double length;
          double metr;
          length = double.Parse(Console.ReadLine());
          metr = length / 100;
          Console.Write(metr);
          Console.WriteLine(" метр");
          Console.ReadKey();
          */
            /* 4. int day = 234;
              double week = day / 7;
              Console.Write("Прошло ");
              Console.Write(week);
              Console.WriteLine(" недель");
              Console.ReadKey();*/

            /*5. int number;
            number = int.Parse(Console.ReadLine());
            int digit1, digit2,sum;
            digit1 = number / 10;
            digit2 = number % 10;
            sum = digit1 + digit2;
            Console.WriteLine(digit1);
            Console.WriteLine(digit2);
            Console.Write("Сумма цифр = ");
            Console.WriteLine(sum);
            Console.ReadKey();*/

         /*6   bool A = true;
            bool B = false;
            bool C = false;
            if(A || B)
            {
                Console.WriteLine(A);
            }
            Console.WriteLine("В) А и В ничего не выводит потому что ложь");
            if (A && B)
            {
                Console.WriteLine(B);
            }
            Console.WriteLine("С) А и В ничего не выводит потому что ложь");
            if (B || C)
            {
                Console.WriteLine(B);
            }
            Console.ReadKey();
            */

            /* 7. int radius = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            double areaCircle, areaSquare;
            areaCircle = Math.Pow(radius,2) * Math.PI;
            areaSquare = length * length;
            Console.WriteLine("{0}  {1}", areaCircle, areaSquare);
            if (areaCircle > areaSquare)
            {
                Console.WriteLine("Площадь круга больше = {0}", areaCircle);
            }
            else
            {
                Console.WriteLine("Площадь квадрата больше = {0}", areaSquare);
            }
            Console.ReadKey(); */


           /* 8. Console.WriteLine("Введите массу и объем первого материала: ");
            int V1 = int.Parse(Console.ReadLine());
            int M1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу и объем второго материала: ");
            int V2 = int.Parse(Console.ReadLine());
            int M2 = int.Parse(Console.ReadLine());
            int P1, P2;
            P1 = M1 * V1;
            P2 = V2 * M2;
            Console.WriteLine("{0} {1}", P1, P2);
            if (P1 > P2)
            {

                Console.WriteLine("Плотность первого материала больше чем у второга = {0}", P1);
            }
            else
            {
                Console.WriteLine("Плотность второго материала больше чем у второга = {0}", P2);
            }
            Console.ReadKey();
            */
            
                /* 9. Console.WriteLine("Введите сопротивление и напряжение первого участка: ");
             int U1 = int.Parse(Console.ReadLine());
             int R1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Введите сопротивление и напряжение второго участка: ");
             int U2 = int.Parse(Console.ReadLine());
             int R2 = int.Parse(Console.ReadLine());
             if (U1 / R1 > U2 / R2)
             {
                 Console.WriteLine("Меньший ток протекает на втором участке = {0}", U2 / R2);
             }
             else
             {
                 Console.WriteLine("Меньший ток протекает на первом участке = {0}", U1 / R1);
             }
             Console.ReadKey();*/
            /* 10. Console.WriteLine("Задача № 10 A:");
            for(int i = 20; i < 36; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Задача № 10 B:");
            Console.WriteLine("Введите цифру (больше 10): ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 10; i < b; i++)
            {
                double number = Math.Pow(i, 2);
                Console.WriteLine(number);
            }

            Console.WriteLine("Задача № 10 C:");
            Console.WriteLine("Введите цифру (меньше 50): ");
            int a = int.Parse(Console.ReadLine());
            for (int i = a; i < 50; i++)
            {
                double number = Math.Pow(i, 3);
                Console.WriteLine(number);
            }
            Console.WriteLine("Задача № 10 D:");
            Console.WriteLine("Введите 2 цифры (oт A до В): ");
            int digit1 = int.Parse(Console.ReadLine());
            int digit2 = int.Parse(Console.ReadLine());
            for (int i = digit1; i <=digit2; i++)
            {
                
                Console.WriteLine(i);
            }
            Console.ReadKey();*/

       }
    }
}
