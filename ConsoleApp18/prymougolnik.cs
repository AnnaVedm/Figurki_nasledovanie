using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Фигурки;

namespace Фигурки
{
    class prymougolnik : figures
    {
        private double b;
        public prymougolnik(double a, double s, double perimetr) : base(a, s, perimetr) { }

        public void Input()
        {
            Console.Write("Введите сторону прямоугольника a(см): ");
            a = Convert.ToSingle(Console.ReadLine());
            if (a <= 0)
            {
                a = proverka_oshibka(a);
            }

            Console.Write("Введите сторону прямоугольника b(см): ");
            b = Convert.ToSingle(Console.ReadLine());

            if (b <= 0)
            {
                b = proverka_oshibka(b);
            }
            Perimetr(a, b);
            S1(a, b);
            Output(s, perimetr);
        }
        private void Perimetr(double a, double b)
        {
            perimetr = Math.Round(2 * (a + b), 3);
        }
        private void S1(double a, double b)
        {
            s = Math.Round(a * b, 3);
        }
    }
}
