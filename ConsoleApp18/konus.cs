using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Фигурки;

namespace Фигурки
{
    class konus : figures
    {
        private double radius;
        private double l;
        private double vysota_h;
        private double obem_fig;
        public konus(double a, double s, double perimetr) : base(a, s, perimetr) { }

        public void input()
        {
            Console.Clear();
            Console.Write("Введите радиус (основания) конуса: ");
            radius = Convert.ToSingle(Console.ReadLine());

            if (radius <= 0)
            {
                radius = proverka_oshibka(radius);
            }

            Console.Write("Введите образующую конуса (отрезок от вершины конуса до границы его основания) l (см): ");
            l = Convert.ToSingle(Console.ReadLine());

            if (l <= 0)
            {
                l = proverka_oshibka(l);
            }

            Console.Write("Введите высоту конуса (отрезок от вершины конуса до центра его основания) h (см): ");
            vysota_h = Convert.ToSingle(Console.ReadLine());

            if (vysota_h <= 0)
            {
                vysota_h = proverka_oshibka(vysota_h);
            }

            S(radius, l, vysota_h);
            P(radius, l);
            obem_figur(radius, l, vysota_h);
            output(perimetr, s, obem_fig);
        }
        private void S(double radius, double l, double vysota_h)
        {
            s = Math.Round(Math.PI * radius * l + Math.PI * Math.Pow(radius, 2), 3);
        }
        private void P(double radius, double l)
        {
            perimetr = Math.Round(radius * Math.PI + l * 2, 3);
        }
        private void obem_figur(double radius, double l, double vysota_h)
        {
            obem_fig = Math.Round((Math.PI * Math.Pow(radius, 2) * vysota_h) / 3, 3);
        }
        private void output(double s, double perimetr, double obem_fig)
        {
            base.Output(s, perimetr);
            Console.WriteLine($"Объем конуса = {obem_fig} см^3\n");
        }
    }
}
