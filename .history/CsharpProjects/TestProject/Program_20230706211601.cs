﻿string message = "tmp:Hi Alf!";

const string openSpan = "H";
const string closeSpan = "f";

int startPosition = message.IndexOf(openSpan);
Console.WriteLine(startPosition);
int endPosition = message.IndexOf(closeSpan);
Console.WriteLine(endPosition);

// openingPosition += openSpan.Length;
/* In der folgenden Zeile werden ArrayIndizes verrechnet.
Der Abstand wird zwischen beiden gemessen.
Abstand von Indize 2 zu 3 ist 1.
Wenn jedoch wie hier die Länge an Stellen berechnet wird,
welche beide Indizewerte einschliesst,
muss +1 hinzuaddiert werden,
da das Objekt von dem aus in eine Richtung (-/+) gewandert wird,
mitgezählt werden muss. */
int length = endPosition - startPosition;
Console.WriteLine(length);
Console.WriteLine(message.Substring(startPosition, length));