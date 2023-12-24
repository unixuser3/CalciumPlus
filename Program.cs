  using System;

internal class CalciumPlus
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Calcium+!");
        System.Threading.Thread.Sleep(2000); // Short delay for effect
        Console.Clear();

        // Initialize num1 and num2 to 0
        double num1 = 0, num2 = 0;
        bool validInput = false;

        // Get the first number
        while (!validInput)
        {
            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }
            validInput = true;
        }

        // Get and validate operation
        char operation = ' '; // Initialize operation
        bool validOperation = false;
        while (!validOperation)
        {
            Console.Write("Choose an operation (+, -, *, /): ");
            operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (operation != '+' && operation != '-' && operation != '*' && operation != '/')
            {
                Console.WriteLine("Invalid operation. Please choose a valid option.");
                continue;
            }

            validOperation = true;
        }

        // Get the second number
        validInput = false; // Reset the validInput flag
        while (!validInput)
        {
            Console.Write("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            validInput = true;
        }

        // Perform and display calculation
        double result;
        try
        {
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {result}");
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {result}");
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        // Trigger the easter egg
                        throw new DivideByZeroException();
                    }
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result}");
                    break;
            }
        }
        catch (DivideByZeroException)
        {
            // ASCII art for infinity
            Console.WriteLine("Whoa, you've discovered an easter egg!");
            Console.WriteLine("      _____           ");
            Console.WriteLine("     /     \\     ");
            Console.WriteLine("    |       |    ");
            Console.WriteLine("     \\     /     ");
            Console.WriteLine("      -----           ");
            Console.WriteLine("Infinity is not a number, but here's something to enjoy!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }
}
```

    This reorganized code first asks the user for the first number, then the operation, and finally the second number. The logical flow is more intuitive and follows the sequence you specified. Make sure to test the application to ensure that the changes work as expected!