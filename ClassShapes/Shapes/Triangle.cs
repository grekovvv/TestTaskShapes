using ClassShapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassShapes.Shapes
{
    public class Triangle : IShapes
    {
        double SideA { get; set; }
        double SideB { get; set; }
        double SideC { get; set; }

        public Triangle(double SideA, double SideB, double SideC)
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
            {
                throw new ArgumentException("Все стороны треугольника должны быть положительными числами");
            }

            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
        }
        /// <summary>
        /// Метод для вычисления прямоугольный ли треугольник
        /// </summary>
        public bool CheckRight()
        {
            double[] sides = new double[] { SideA, SideB, SideC };
            Array.Sort(sides);

            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
        
        /// <summary>
        /// Метод для вычисления площади треугольника по трем сторонам с использованием формулы Герона
        /// </summary>
        public double CalculateArea()
        {
            var polygon = new Polygon(SideA, SideB, SideC);
            return polygon.CalculateArea();
        }
    }
}
