﻿// string message = "tmp:Hi Alf!";

// const string openSpan = "H";
// const string closeSpan = "f";

// int startPosition = message.IndexOf(openSpan);
// Console.WriteLine(startPosition);
// int endPosition = message.IndexOf(closeSpan);
// Console.WriteLine(endPosition);

// // openingPosition += openSpan.Length;
// /* In der folgenden Zeile werden ArrayIndizes verrechnet.
// Der Abstand/Weg (die Anzahl der Verbindungen/Relationen zwischen den einzelnen Elementen) wird zwischen beiden gemessen.
// Abstand von Indize 2 zu 3 ist 1.
// Wenn jedoch wie hier die Länge an Stellen berechnet wird,
// welche beide Indizewerte einschliesst,
// muss +1 hinzuaddiert werden,
// da das Objekt von dem aus in eine Richtung (-/+) gewandert wird,
// mitgezählt werden muss. */
// int length = (endPosition - startPosition) + 1;
// Console.WriteLine(length);
// Console.WriteLine(message.Substring(startPosition, length));

/* string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length)); */

/* string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');
    // Console.WriteLine(openingPosition);
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
    // Console.WriteLine(message.Length);
} */

/* string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 6;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition: {message.Substring(openingPosition)}"); */

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    Console.WriteLine(message.ElementAt(openingPosition));

    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}