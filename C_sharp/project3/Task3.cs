using System;

class Program
{
    static void Main()
    {
        // Integer (int)
        int intMin = int.MinValue; // Get the minimum value of int
        int intMax = int.MaxValue; // Get the maximum value of int
        Console.WriteLine("Int Min: " + intMin); // Print the minimum value of int
        Console.WriteLine("Int Max: " + intMax); // Print the maximum value of int
        Console.WriteLine("Int Range: " + (intMax - intMin)); // Calculate and print the range of int

        // Long (long)
        long longMin = long.MinValue; // Get the minimum value of long
        long longMax = long.MaxValue; // Get the maximum value of long
        Console.WriteLine("Long Min: " + longMin); // Print the minimum value of long
        Console.WriteLine("Long Max: " + longMax); // Print the maximum value of long
        Console.WriteLine("Long Range: " + (longMax - longMin)); // Calculate and print the range of long

        // Double (double)
        double doubleMin = double.MinValue; // Get the minimum value of double
        double doubleMax = double.MaxValue; // Get the maximum value of double
        Console.WriteLine("Double Min: " + doubleMin); // Print the minimum value of double
        Console.WriteLine("Double Max: " + doubleMax); // Print the maximum value of double
        Console.WriteLine("Double Range: " + (doubleMax - doubleMin)); // Calculate and print the range of double

        // String (string)
        // Note: String does not have a specific min or max value, as it can hold any length of characters.
        // However, we can get the maximum capacity of a string, which is theoretically limited by available memory.
        Console.WriteLine("String does not have a specific min or max value."); // Print a message indicating that string does not have a specific min or max value.
    }
}