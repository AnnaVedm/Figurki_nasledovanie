using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Фигурки;

namespace Фигурки
{
    class square : figures
    {
        public square(double a, double s, double perimetr) : base(a, s, perimetr) { }

        private void Perimetr(double a)
        {
            perimetr = Math.Round(4 * a, 3);
        }
        public void input()
        {
            Console.Write("Введите сторону квадрата a(см): ");
            a = Convert.ToSingle(Console.ReadLine());

            if (a <= 0)
            {
                a = proverka_oshibka(a);
            }
            Perimetr(a);
            s = S(a, s);
            Output(s, perimetr);
        }
        private double S(double a, double s)
        {
            s = Math.Round(a * a, 3);
            return s;
        }
    }
}
