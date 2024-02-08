using ClassShapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassShapes.Shapes
{
    public class Polygon : IShapes
    {
        double[]? sides { get; set; }

        public Polygon(params double[] sides)
        {
            this.sides = sides;
        }

        public double CalculateArea()
        {
            return CalculatePolygonArea(sides);
        }
        private double CalculatePolygonArea(params double[] sides)
        {
            if (sides == null || sides.Length < 3)
            {
                throw new ArgumentException("Многоугольник должен иметь как минимум 3 стороны");
            }

            double p = 0;
            foreach (double side in sides)
            {
                //опционально, можно валидировать на стороне клиента, вызывающего метод
                if (side <= 0)
                {
                    throw new ArgumentException("Длина стороны многоугольника должна быть положительным числом");
                }
                p += side;
            }
            p /= 2;

            double area = p;
            foreach (double side in sides)
            {
                area *= (p - side);
            }
            return Math.Sqrt(area);
        }
    }
}
