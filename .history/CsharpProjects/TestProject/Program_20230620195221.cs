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



/* Console.WriteLine("Enter one of the following role names: Administrator, Manager, or User");
string userInput;
string userInput_original;
Boolean askForNewUserInput = true;

do
{
    userInput = Console.ReadLine().Trim().ToLower();

    // userInput = Console.ReadLine();
    // userInput_original = String.Copy(userInput);
    // userInput = userInput.Trim().ToLower();

    switch (userInput)
    {
        case "administrator":
        case "manager":
        case "user":
            askForNewUserInput = false;
            break;
        default:
            Console.WriteLine("Enter one of the following role names: Administrator, Manager, or User");
            continue;
    }

} while (askForNewUserInput);

Console.WriteLine($"Input value {userInput} has been accepted."); */



string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;
string myString;

for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    //no period in current String
    if (periodLocation == -1)
        periodLocation = myString.Length;

    /* //iterate String until periodLocation or Array.Length
    Boolean afterLastSentence = false;
    do
    {
        Console.WriteLine(myString.Substring(0, periodLocation));
        myString.Remove(0, periodLocation);
        // myString = myString.Remove(0, periodLocation);


        myString.TrimStart();
        // myString = myString.TrimStart();

        periodLocation = myString.IndexOf(".");
        if (periodLocation == -1)
            afterLastSentence = true;

    } while (!afterLastSentence); */
};