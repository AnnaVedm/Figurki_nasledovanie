using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигурки
{
    class figures
{
    protected double a;
    protected double s;
    protected double perimetr;
    public figures(double a, double s, double perimetr)
    {
        this.a = a;
        this.s = s;
        this.perimetr = perimetr;
    }

    public virtual void Output(double s, double perimetr)
    {
        Console.WriteLine($"\nПериметр фигуры = {perimetr} см");
        Console.WriteLine($"\nПлощадь фигуры = {s} см^2\n");
    }

    protected double proverka_oshibka(double a)
    {
        while (a <= 0)
        {
            Console.WriteLine("Такое значение невозможно. Попробуйте ввести данные ещё раз.");
            Console.Write("Введите сторону фигуры (см): ");
            a = double.Parse(Console.ReadLine());
        }
        return a;
    }
}
}
