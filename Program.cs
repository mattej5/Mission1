// See https://aka.ms/new-console-template for more information

using Mission1;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");

        // Choose number of dice rolls
        Console.WriteLine("How many dice rolls would you like to simulate? ");
        int diceRolls = int.Parse(Console.ReadLine());  // User input for number of dice rolls

        // Pass number to second class and get the array back
        int[] diceArray = DiceRollSim.DiceRollMethod(diceRolls);

        // Create a histogram
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\nEach '*' represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + diceRolls + "\n");
        for (int i = 2; i <= 12; i++) // Loop through sums 2–12
        {
            string asterisks = "";
            int numAsterisks = (diceArray[i - 2] * 100) / diceRolls; // Calculate percentage

            for (int j = 0; j < numAsterisks; j++) // Build histogram bar
            {
                asterisks += "*";
            }
            Console.WriteLine($"{i}: {asterisks}"); // Output histogram
        }
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}
