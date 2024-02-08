
using ClassShapes.Shapes;
using ClassShapes.Interfaces;
using ClassShapes.Helper;
using System.Collections.Specialized;

namespace TestTaskShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Напишите тип фигуры: \n" +
                        "c - Circle,\n" +
                        "t - Triangle,\n" +
                        "p - Polygon, \n" +
                        "q - то есть, не указываете фигуру (так называемый compile-time)\n" +
                        "check - проверить примоугольный ли треугольник\n" +
                        "Или напишите 'e', чтобы выйти из программы:\n\n");
                    string? type = Console.ReadLine();
                    if (type == null || type == "e")
                        break;

                    Console.WriteLine("Теперь передайте аргументы в формате перечисления чисел через пробел: \n");
                    string? consoleAgr = Console.ReadLine();
                    if (consoleAgr == null || consoleAgr == "e")
                        break;
                    if(type == "check")
                    {
                        bool result = Util.GetResultCheckTriangle(consoleAgr);
                        if (result)
                            Console.WriteLine("Да, теругольник прямоугольный" + "\n\n");
                        else
                        {
                            Console.WriteLine("нет, теругольник непрямоугольный" + "\n\n");
                        }
                    }
                    else
                    {
                        double? result = Util.GetResult(consoleAgr, type);
                        if (result == null)
                            Console.WriteLine("Повторите ещё раз" + "\n\n");
                        else
                        {
                            Console.WriteLine("Ответ: " + result + "\n\n");
                        }
                    }
                    


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("End of program");
            Console.ReadLine();

        }
        
    }
}
