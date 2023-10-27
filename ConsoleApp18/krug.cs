using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Фигурки;

namespace Фигурки
{
    class krug : figures
    {
        private double radius;
        public krug(double a, double s, double perimetr) : base(a, s, perimetr) { }
        public void input() //запись данных о круге
        {
            Console.Write("Введите радиус круга r(см): ");
            radius = Convert.ToSingle(Console.ReadLine());
            if (radius <= 0)
            {
                radius = proverka_oshibka(radius);
            }
            Perimetr_krug(radius);
            S2(radius);
            Output(perimetr, s);
        }
        private void Perimetr_krug(double radius) //расчет длины окружности
        {
            perimetr = Math.Round(2 * Math.PI * radius, 3);
        }
        private void S2(double radius)
        {
            s = Math.Round(Math.PI * (radius * radius), 3);
        }
    }
}
