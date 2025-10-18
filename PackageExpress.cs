using System;

class Program
{
    static void Main()
    {
        // Welcome message to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for package weight
        Console.Write("Please enter the package weight: ");
        double weight;

        // Validate weight input
        if (!double.TryParse(Console.ReadLine(), out weight))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value for weight.");
            return;
        }

        // If weight is over 50, show error and exit
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Prompt user for package width
        Console.Write("Please enter the package width: ");
        double width;
        if (!double.TryParse(Console.ReadLine(), out width))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value for width.");
            return;
        }

        // Prompt user for package height
        Console.Write("Please enter the package height: ");
        double height;
        if (!double.TryParse(Console.ReadLine(), out height))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value for height.");
            return;
        }

        // Prompt user for package length
        Console.Write("Please enter the package length: ");
        double length;
        if (!double.TryParse(Console.ReadLine(), out length))
        {
            Console.WriteLine("Invalid input. Please enter a numeric value for length.");
            return;
        }

        // Check if total dimensions exceed 50
        double dimensionSum = width + height + length;
        if (dimensionSum > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate quote: (width * height * length * weight) / 100
        double quote = (width * height * length * weight) / 100;

        // Display quote to user
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
        Console.WriteLine("Thank you!");
    }
}

