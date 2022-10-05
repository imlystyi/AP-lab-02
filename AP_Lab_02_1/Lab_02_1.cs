// Lab_02_1.cs
// Якубовський Владислав
// Лабораторна робота № 2.
// Лінійні програми.
// Варіант 24
using System;

namespace AP_Lab_02_1
{
    internal class Lab_02_1
    {
        static void Main()
        {
            double ConvertDegToRad(double angleToConvert) => (Math.PI / 180) * angleToConvert;

            Console.Write("alpha: ");
            double alpha = ConvertDegToRad(Double.Parse(Console.ReadLine()));

            double z1 = (Math.Sin(alpha) + Math.Sin(5 * alpha) - Math.Sin(3 * alpha)) / (Math.Cos(alpha) - Math.Cos(3 * alpha) + Math.Cos(5 * alpha)),
                z2 = Math.Tan(3 * alpha);

            Console.WriteLine($"z1 = {z1};\nz2 = {z2};\n");

            Console.ReadLine();
        }
    }
}
