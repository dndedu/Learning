using System;

Console.WriteLine("Enter a number between 5 and 10 (incl.)");
string userInput;

do
{
    userInput = Console.ReadLine();
    if (userInput < 5 || userInput > 10)
    {
        Console.WriteLine("Enter a number between 5 and 10 (incl.)");
        continue;
    }
} while (true);