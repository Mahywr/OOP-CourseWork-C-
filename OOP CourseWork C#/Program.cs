// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello Mahyy, Good luck with your study");
Console.WriteLine("Haavaa, Chetoreeh?");
string input = Console.ReadLine(); // Read input as a string
int a;
if (int.TryParse(input, out a)) // Try to parse the input as an integer
{
    if (a == 0) // Use "if" without a semicolon
    {
        Console.WriteLine("You entered 0. Please enter another number.");
    }
    else
    {
        Console.WriteLine("You entered: " + a); // Corrected the output message
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}
