using System;

Console.WriteLine("Enter a number between 5 and 10 (incl.)");
string userInput;

do
{
    userInput = Console.ReadLine();
    //TODO string to number, check if number
    if (userInput < 5 || userInput > 10)
    {
        Console.WriteLine("Enter a number between 5 and 10 (incl.)");
        continue;
    }
} while (true);

Console.WriteLine($"Input value {userInput} has been accepted.");