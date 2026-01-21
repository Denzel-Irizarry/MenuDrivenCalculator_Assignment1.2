using System.Xml.Serialization;

namespace MenuDrivenCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Console Calculator");
            MainMenu();
            
        }
        static void MainMenu()
        {
            char exit = 'n';
            string? choice;

            while (exit == 'n' || exit == 'N')
            {
                //choices to pick from 
                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine();

                Console.WriteLine("1. Addition");
                Console.WriteLine();

                Console.WriteLine("2. Subtraction");
                Console.WriteLine();

                Console.WriteLine("3. Multiplication");
                Console.WriteLine();

                Console.WriteLine("4. Division");
                Console.WriteLine();

                Console.WriteLine("5. Exit");
                Console.WriteLine();

                Console.WriteLine("Please make a selection");
                choice = Console.ReadLine().ToLower();


                switch (choice)
                {
                    case "1":
                    case "addition":
                        AdditionFunction();
                        break;

                    case "2":
                    case "subtraction":
                        SubtractionFunction();
                        break;
                    case "3":
                    case "multiplication":
                        MultiplicationFunction();
                        break;
                    case "4":
                    case "division":
                        DivisionFunction();
                        break;
                    case "5":
                    case "exit":
                        exit = 'y';
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid selection press any key to return to selection.");
                        Console.ReadKey();
                        break;

                }
            }
        }

        static void AdditionFunction()
        {
            Console.Clear();
            Console.WriteLine("Addition Selected");
            Console.WriteLine();
            int numOne = 0;
            int numTwo = 0;
            try
            {
                Console.WriteLine("Please enter a number:");
                while (!int.TryParse(Console.ReadLine(), out numOne))
                {
                    throw new Exception();
                }
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Number cannot be empty. Returning to main menu.");
                return;
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message} \nReturning to main menu.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message} \nReturning to main menu.");
                Console.Clear();
                Console.ReadKey();
                return;
            }
            Console.WriteLine();

            try
            {
                Console.WriteLine("Please enter a second number:");
                while (!int.TryParse(Console.ReadLine(), out numTwo))
                {
                    throw new Exception();
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Number cannot be empty. Returning to main menu.");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Returning to main menu.");
                Console.Clear();
                return;
            }
            Console.WriteLine();

            Console.WriteLine($"The sum of {numOne} and {numTwo} is {numOne + numTwo}");
            Console.WriteLine();

            Console.WriteLine("Please enter any key to return to Main Menu");
            Console.ReadKey();
            Console.Clear();
            return;
        }
        static void SubtractionFunction()
        {
            Console.Clear();
            Console.WriteLine("Subtraction Selected");
            Console.WriteLine();
            int numOne = 0;
            int numTwo = 0;
            try
            {
                Console.WriteLine("Please enter a number:");
                while (!int.TryParse(Console.ReadLine(), out numOne))
                {
                    throw new Exception();
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Number cannot be empty. Returning to main menu.");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Returning to main menu.");
                Console.Clear();
                return;
            }
            Console.WriteLine();

            try
            {
                Console.WriteLine("Please enter a second number:");
                while (!int.TryParse(Console.ReadLine(), out numTwo))
                {
                    throw new Exception();
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Number cannot be empty. Returning to main menu.");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Returning to main menu.");
                Console.Clear();
                return;
            }
            Console.WriteLine();

            Console.WriteLine($"The difference of {numOne} and {numTwo} is {numOne - numTwo}");
            Console.WriteLine();

            Console.WriteLine("Please enter any key to return to Main Menu");
            Console.ReadKey();
            Console.Clear();
            return;
        }
        static void MultiplicationFunction()
        {
            Console.Clear();
            Console.WriteLine("Multiplication Selected");
            Console.WriteLine();
            int numOne = 0;
            int numTwo = 0;
            try
            {
                Console.WriteLine("Please enter a number:");
                while (!int.TryParse(Console.ReadLine(), out numOne))
                {
                    throw new Exception();
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Number cannot be empty. Returning to main menu.");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Returning to main menu.");
                Console.Clear();
                return;
            }
            Console.WriteLine();

            try
            {
                Console.WriteLine("Please enter a second number:");
                while (!int.TryParse(Console.ReadLine(), out numTwo))
                {
                    throw new Exception();
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Number cannot be empty. Returning to main menu.");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Returning to main menu.");
                Console.Clear();
                return;
            }
            Console.WriteLine();

            Console.WriteLine($"The product of {numOne} and {numTwo} is {numOne * numTwo}");
            Console.WriteLine();

            Console.WriteLine("Please enter any key to return to Main Menu");
            Console.ReadKey();
            Console.Clear();
            return;
        }
        static void DivisionFunction()
        {
            Console.Clear();
            Console.WriteLine("Division Selected");
            Console.WriteLine();
            int numOne = 0;
            int numTwo = 0;
            try
            {
                Console.WriteLine("Please enter a number:");
                while (!int.TryParse(Console.ReadLine(), out numOne))
                {
                    throw new Exception();
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Number cannot be empty. Returning to main menu.");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Returning to main menu.");
                Console.Clear();
                return;
            }
            Console.WriteLine();

            try
            {
                Console.WriteLine("Please enter a second number:");
                while (!int.TryParse(Console.ReadLine(), out numTwo))
                {
                    throw new Exception();
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Number cannot be empty. Returning to main menu.");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Returning to main menu.");
                Console.Clear();
                return;
            }
            Console.WriteLine();

            Console.WriteLine($"The qoutient of {numOne} and {numTwo} is {numOne / numTwo}");
            Console.WriteLine();

            Console.WriteLine("Please enter any key to return to Main Menu");
            Console.ReadKey();
            Console.Clear();
            return;
        }
    }
}
