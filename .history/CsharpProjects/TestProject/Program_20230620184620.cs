﻿using System;

Console.WriteLine("Enter a number between 5 and 10 (incl.)");
string userInput;
Boolean enterNewNumber = true;
do
{
    userInput = Console.ReadLine();

    switch (userInput)
    {
        case "5":
        case "6":
        case "7":
        case "8":
        case "9":
        case "10":
            enterNewNumber = false;
    }

    if (userInput < 5 || userInput > 10)
    {
        Console.WriteLine("Enter a number between 5 and 10 (incl.)");
        continue;
    }
} while (enterNewNumber);

Console.WriteLine($"Input value {userInput} has been accepted.");