using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    public class Calculator
    {
        private double previousResult;

        public Calculator()
        {
            previousResult = 0.0;
        }

        // Addition zweier Zahlen
        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            previousResult = result;
            return result;
        }

        // Subtraktion zweier Zahlen
        public double Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            previousResult = result;
            return result;
        }

        // Multiplikation zweier Zahlen
        public double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            previousResult = result;
            return result;
        }

        // Division zweier Zahlen
        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Division by zero is not allowed.");
            }

            double result = num1 / num2;
            previousResult = result;
            return result;
        }

        // Potenzieren einer Zahl
        public double Power(double num, double exponent)
        {
            double result = Math.Pow(num, exponent);
            previousResult = result;
            return result;
        }

        // Wurzel ziehen einer Zahl
        public double SquareRoot(double num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Square root of a negative number is not allowed.");
            }

            double result = Math.Sqrt(num);
            previousResult = result;
            return result;
        }

        // Berechnung des Logarithmus einer Zahl zur Basis 10
        public double Logarithm(double num)
        {
            if (num <= 0)
            {
                throw new ArgumentException("Logarithm of a non-positive number is not allowed.");
            }

            double result = Math.Log10(num);
            previousResult = result;
            return result;
        }

        // Berechnung der Fakultät einer Zahl
        public double Factorial(int num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Factorial of a negative number is not allowed.");
            }

            double result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            previousResult = result;
            return result;
        }

        // Berechnung des Sinus einer Zahl in Grad
        public double Sin(double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * Math.PI / 180.0;
            double result = Math.Sin(angleInRadians);
            previousResult = result;
            return result;
        }

        // Berechnung des Cosinus einer Zahl in Grad
        public double Cos(double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * Math.PI / 180.0;
            double result = Math.Cos(angleInRadians);
            previousResult = result;
            return result;
        }

        // Berechnung des Tangens einer Zahl in Grad
        public double Tan(double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * Math.PI / 180.0;
            double result = Math.Tan(angleInRadians);
            previousResult = result;
            return result;
        }

        // Rückgabe des vorherigen Ergebnisses
        public double GetPreviousResult()
        {
            return previousResult;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            // Benutzerinteraktion
            Console.WriteLine("Willkommen beim Taschenrechner!");

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nBitte wählen Sie eine Operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraktion");
                Console.WriteLine("3. Multiplikation");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Potenzieren");
                Console.WriteLine("6. Wurzel ziehen");
                Console.WriteLine("7. Logarithmus");
                Console.WriteLine("8. Fakultät");
                Console.WriteLine("9. Sinus");
                Console.WriteLine("10. Cosinus");
                Console.WriteLine("11. Tangens");
                Console.WriteLine("0. Beenden");

                string userInput = Console.ReadLine();
                int operation;
                if (int.TryParse(userInput, out operation))
                {
                    double result = 0.0;
                    double num1, num2;
                    int num;
                    switch (operation)
                    {
                        case 0:
                            running = false;
                            Console.WriteLine("Taschenrechner wird beendet.");
                            break;
                        case 1:
                            Console.Write("Geben Sie die erste Zahl ein: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Geben Sie die zweite Zahl ein: ");
                            num2 = double.Parse(Console.ReadLine());
                            result = calculator.Add(num1, num2);
                            Console.WriteLine("Ergebnis: " + result);
                            break;
                        case 2:
                            Console.Write("Geben Sie die erste Zahl ein: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Geben Sie die zweite Zahl ein: ");
                            num2 = double.Parse(Console.ReadLine());
                            result = calculator.Subtract(num1, num2);
                            Console.WriteLine("Ergebnis: " + result);
                            break;
                        case 3:
                            Console.Write("Geben Sie die erste Zahl ein: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Geben Sie die zweite Zahl ein: ");
                            num2 = double.Parse(Console.ReadLine());
                            result = calculator.Multiply(num1, num2);
                            Console.WriteLine("Ergebnis: " + result);
                            break;
                        case 4:
                            Console.Write("Geben Sie die erste Zahl ein: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Geben Sie die zweite Zahl ein: ");
                            num2 = double.Parse(Console.ReadLine());
                            try
                            {
                                result = calculator.Divide(num1, num2);
                                Console.WriteLine("Ergebnis: " + result);
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case 5:
                            Console.Write("Geben Sie die Basiszahl ein: ");
                            num1 = double.Parse(Console.ReadLine());
                            Console.Write("Geben Sie den Exponenten ein: ");
                            num2 = double.Parse(Console.ReadLine());
                            result = calculator.Power(num1, num2);
                            Console.WriteLine("Ergebnis: " + result);
                            break;
                        case 6:
                            Console.Write("Geben Sie die Zahl ein: ");
                            num1 = double.Parse(Console.ReadLine());
                            try
                            {
                                result = calculator.SquareRoot(num1);
                                Console.WriteLine("Ergebnis: " + result);
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case 7:
                            Console.Write("Geben Sie die Zahl ein: ");
                            num1 = double.Parse(Console.ReadLine());
                            try
                            {
                                result = calculator.Logarithm(num1);
                                Console.WriteLine("Ergebnis: " + result);
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case 8:
                            Console.Write("Geben Sie die Zahl ein: ");
                            num = int.Parse(Console.ReadLine());
                            try
                            {
                                result = calculator.Factorial(num);
                                Console.WriteLine("Ergebnis: " + result);
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        case 9:
                            Console.Write("Geben Sie den Winkel in Grad ein: ");
                            num1 = double.Parse(Console.ReadLine());
                            result = calculator.Sin(num1);
                            Console.WriteLine("Ergebnis: " + result);
                            break;
                        case 10:
                            Console.Write("Geben Sie den Winkel in Grad ein: ");
                            num1 = double.Parse(Console.ReadLine());
                            result = calculator.Cos(num1);
                            Console.WriteLine("Ergebnis: " + result);
                            break;
                        case 11:
                            Console.Write("Geben Sie den Winkel in Grad ein: ");
                            num1 = double.Parse(Console.ReadLine());
                            result = calculator.Tan(num1);
                            Console.WriteLine("Ergebnis: " + result);
                            break;
                        default:
                            Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie eine der angegebenen Optionen.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                }
            }
        }
    }
}