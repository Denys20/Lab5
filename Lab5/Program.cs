using System;
using System.Text;

namespace Lab5
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Арифметичні і логічні операції для комплексних чисел");

            Calculator calculator = new Calculator();

            Complex a = new Complex(6, 7);
            Complex b = new Complex(1, 2);
            Complex c = new Complex(1, 2);
            Complex result;

            result = calculator.Add(a, b);
            Console.WriteLine("\n{0} + {1} = {2}", a, b, result);

            result = calculator.Sub(a, b);
            Console.WriteLine("\n{0} - {1} = {2}", a, b, result);

            result = calculator.Mul(a, b);
            Console.WriteLine("\n{0} * {1} = {2}", a, b, result);

            result = calculator.Div(a, b);
            Console.WriteLine("\n{0} / {1} = {2}", a, b, result);

            Console.WriteLine("\n{0} == {1} is {2}", a, b, calculator.Equal(a, b));
            Console.WriteLine("\n{0} != {1} is {2}", a, b, calculator.NotEqual(a, b));
            Console.WriteLine("\n{0} == {1} is {2}", c, b, calculator.Equal(c, b));

            Console.WriteLine("\nНатисніть будь-яку клавішу, щоб вийти...");
            Console.ReadKey();
        }
    }
}
