// string message = "tmp:Hi Alf!";

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

string message = "(What if) there are (more than) one (set of parentheses)?";
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
}