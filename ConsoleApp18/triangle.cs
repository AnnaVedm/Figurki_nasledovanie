using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Фигурки;

namespace Фигурки
{
    class triangle : figures
    {
        private double b;
        private double c;
        private double p;// Полупериметр для формулы герона

        public triangle(double a, double s, double perimetr) : base(a, s, perimetr) { }

        private void Perimetr(double a, double storona_b, double storona_c)
        {
            perimetr = Math.Round(a + storona_b + storona_c, 3);
        }
        private void S3(double storona_a, double storona_b, double storona_c)
        {
            p = (storona_a + storona_b + storona_c) / 2;
            s = Math.Round(Math.Sqrt(p * (p - storona_a) * (p - storona_b) * (p - storona_c)), 3);
        }
        public void input()
        {
            Console.Write("Введите сторону треугольника a(см): ");
            a = Convert.ToSingle(Console.ReadLine());

            if (a <= 0)
            {
                a = proverka_oshibka(a);
            }

            Console.Write("Введите сторону треугольника b(см): ");
            b = Convert.ToSingle(Console.ReadLine());

            if (b <= 0)
            {
                a = proverka_oshibka(b);
            }

            Console.Write("Введите сторону треугольника с(см): ");
            c = Convert.ToSingle(Console.ReadLine());

            if (c <= 0)
            {
                c = proverka_oshibka(c);
            }

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Такое значение невозможно для стороны треугольника. Попробуйте ввести данные ещё раз.");
                input();
            }
            else
            {

                if ((a + b) <= c || (b + c) <= a || (a + c) <= b)
                {
                    Console.WriteLine("\nТакой треугольник не существует! Попробуйте ввести данные ещё раз\n");
                    input();
                }
                else if (a == b && b == c)
                    Console.WriteLine("\nВаш треугольник равноcторонний!\n");

                else if (a == b || b == c || c == a)
                    Console.WriteLine("\nВаш треугольник равнобедренный!\n");

                else if (a != b || b != c || c != a)
                    Console.WriteLine("\nВаш треугольник разносторонний!\n");

                if ((a * a) + (b * b) == c * c || (b * b) + (c * c) == a * a)
                    Console.WriteLine("\nВаш треугольник прямоугольный!\n");

                Perimetr(a, b, c);
                S3(a, b, c);
                Output(perimetr, s);

            }

        }
    }
}
