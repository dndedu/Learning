/*
    reverse message
    count number of specified chars
    print both results
*/

string message = "The quick brown fox jumps over the lazy dog.";
char[] reversedMessage = message.ToCharArray();
Array.Reverse(reversedMessage);

int letterCount = 0;
foreach (char i in reversedMessage)
{
    if (i == 'o')
    {
        letterCount++;
    }
}

string new_message = new String(reversedMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {letterCount} times.");