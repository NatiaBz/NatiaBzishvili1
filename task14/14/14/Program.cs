using System;

namespace SimpleCalculator
{
   
    public class CustomCalculatorException : Exception
    {
        public int StatusCode { get; set; }

        public CustomCalculatorException(string message, int statusCode)
            : base(message)
        {
            StatusCode = statusCode;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            string operation;

            while (true)
            {
                try
                {
        
                    Console.Write("Seikvanet pirveli cifri: ");
                    if (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        throw new FormatException("araswori cifria, gTxov Seiyvanot swori cifri.");
                    }

                    Console.Write("Seikvanet meore cifri: ");
                    if (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        throw new FormatException("araswori cifria, gTxov Seiyvanot swori cifri.");
                    }

   
                    Console.Write("Seikvanet maT operacia (+, -, *, /): ");
                    operation = Console.ReadLine();

                    if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                    {
                        throw new InvalidOperationException("Araswori simboloa");
                    }

                
                    switch (operation)
                    {
                        case "+":
                            result = num1 + num2;
                            break;

                        case "-":
                            result = num1 - num2;
                            break;

                        case "*":
                            result = num1 * num2;
                            break;

                        case "/":
                            if (num2 == 0)
                            {
                                throw new DivideByZeroException("0-ze gayofa SeuZlebelia, gtxovT scadoT Tavidan");
                            }
                            result = num1 / num2;
                            break;

                        default:
                            result = 0;
                            break;
                    }

                 
                    Console.WriteLine($"Sedegi: {result}");
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (CustomCalculatorException ex)
                {
                    Console.WriteLine($"Custom Error: {ex.Message} | Status Code: {ex.StatusCode}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"wash: {ex.Message}");
                }
            }
        }
    }
}

