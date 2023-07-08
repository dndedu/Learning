string message = "tmp:Hi Alf!";

const string openSpan = "H";
const string closeSpan = "f";

int openingPosition = message.IndexOf(openSpan);
Console.WriteLine(openingPosition);
int closingPosition = message.IndexOf(closeSpan);
Console.WriteLine(closingPosition);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));