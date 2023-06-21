//https://learn.microsoft.com/en-us/training/modules/csharp-do-while/5-exercise-challenge-differentiate-while-do-statements

/* //1 own solution 
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
            break;
        default:
            Console.WriteLine("Enter a number between 5 and 10 (incl.)");
            continue;
    }

} while (enterNewNumber);

Console.WriteLine($"Input value {userInput} has been accepted."); */

/* //1 MS-Solution with string?, explicit null-handling, but esp. int.TryParse, which haven't been introduced in the course
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine(); */



//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



/* //2 own solution
Console.WriteLine("Enter one of the following role names: Administrator, Manager, or User");
string userInput;
string userInput_modified;
Boolean askForNewUserInput = true;

do
{
    userInput = Console.ReadLine();
    userInput_modified = userInput.Trim().ToLower();

    switch (userInput_modified)
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

/* //2 MS-solution; note: 
string? readResult;
string roleName = "";
bool validEntry = false;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine(); */



//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



/* //3 own solution
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;
string myString;

for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];

    periodLocation = myString.IndexOf(".");

    //iterate String until periodLocation or Array.Length
    Boolean noMoreSentence = false;
    do
    {
        if (periodLocation == -1)
        {
            noMoreSentence = true;
            periodLocation = myString.Length - 1;
        }
        Console.WriteLine(myString.Substring(0, periodLocation + 1));
        Console.WriteLine("after Substring:" + myString);
        myString = myString.Remove(0, periodLocation + 1);
        Console.WriteLine("after Remove: " + myString);
        myString = myString.TrimStart();
        Console.WriteLine("after TrimStart: " + myString);

        periodLocation = myString.IndexOf(".");
        Console.WriteLine(periodLocation);

        Console.ReadLine();
    } while (!noMoreSentence);
}; */