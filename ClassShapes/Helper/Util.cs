using ClassShapes.Interfaces;
using ClassShapes.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ClassShapes.Helper
{
    public class Util
    {
        public static double? GetResult(string isNumber, string type)
        {
            double? result = null;

            double[] numbers = ParseNumber(isNumber);
            if (numbers.Length == 0)
                return null;

            IShapes shapes;

            if (type == "c" || numbers.Length == 1)
            {
                shapes = new Circle(numbers[0]);
                result = shapes.CalculateArea();
            }
            else if (type == "t" || numbers.Length == 3)
            {
                shapes = new Triangle(numbers[0], numbers[1], numbers[2]);
                result = shapes.CalculateArea();
            }
            else if (type == "p" || numbers.Length > 3)
            {
                shapes = new Polygon(numbers);
                result = shapes.CalculateArea();
            }
            else if (type == "check" || numbers.Length == 3)
            {
                shapes = new Triangle(numbers[0], numbers[1], numbers[2]);
                result = shapes.CalculateArea();
            }

            return result;
        }

        public static bool GetResultCheckTriangle(string isNumber)
        {
            bool result = false;

            double[] numbers = ParseNumber(isNumber);
            if (numbers.Length == 0)
                return false;

            
            if (numbers.Length == 3)
            {
                Triangle triangle = new Triangle(numbers[0], numbers[1], numbers[2]);
                result = triangle.CheckRight();
            }
            else
            {
                Console.WriteLine("Должно быть три стороны!");
            }

            return result;
        }

        /// <summary>
        /// Парсим стринг в дабл
        /// </summary>
        /// <param name="isNumber"></param>
        /// <returns></returns>
        static double[] ParseNumber(string input)
        {
            try
            {
                string[] values = input.Split(' ');
                var numbers = new List<double>();

                foreach (string value in values)
                {
                    if (value == "")
                        continue;
                    if (double.TryParse(value, out double result))
                    {
                        numbers.Add(result);
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге значения \"{value}\".");
                    }
                }

                double[] numbersArray = numbers.ToArray();
                return numbersArray;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new double[0];
            }
            
        }
    }
}
