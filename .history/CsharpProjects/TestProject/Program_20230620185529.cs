using System;

//https://learn.microsoft.com/en-us/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements

/* Console.WriteLine("Enter a number between 5 and 10 (incl.)");
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
            break;
        default:
            Console.WriteLine("Enter a number between 5 and 10 (incl.)");
            continue;
    }

} while (enterNewNumber);

Console.WriteLine($"Input value {userInput} has been accepted."); */


Console.WriteLine("Enter one of the following role names: Administrator, Manager, or User");
string userInput;
Boolean askForNewUserInput = true;

do
{
    userInput = Console.ReadLine().Trim().ToLower();

    switch (userInput)
    {
        case "Administrator":
        case "Manager":
        case "User":
            askForNewUserInput = false;
            break;
        default:
            Console.WriteLine("Enter a number between 5 and 10 (incl.)");
            continue;
    }

} while (askForNewUserInput);

Console.WriteLine($"Input value {userInput} has been accepted.");