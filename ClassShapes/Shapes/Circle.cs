using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassShapes.Interfaces;

namespace ClassShapes.Shapes
{
    public class Circle : IShapes
    {
        double Radius { get; set; }

        public Circle(double Radius)
        {
            if (Radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом");
            }

            this.Radius = Radius;
        }

        /// <summary>
        /// Метод для вычисления площади круга по радиусу
        /// </summary>
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
