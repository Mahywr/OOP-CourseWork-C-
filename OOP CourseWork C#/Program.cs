using System;

Console.WriteLine("Hello Mahyy, Good luck with your study");
Console.WriteLine("Haavaa, Chetoreeh?");
string input = Console.ReadLine();

try
{
    int a = Convert.ToInt32(input);

    if (a == 0)
    {
        Console.WriteLine("You entered 0. Please enter another number.");
    }
    else
    {
        Console.WriteLine("You entered: " + a);
    }
}
catch (FormatException)
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}
catch (OverflowException)
{
    Console.WriteLine("The number you entered is too large or too small.");
}
