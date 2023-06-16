//reverse string to charArray
string message = "The quick brown fox jumps over the lazy dog.";
char[] reversedMessage = message.ToCharArray();
Array.Reverse(reversedMessage);

int x = 0;
foreach (char i in reversedMessage)
{
    if (i == 'o')
    {
        x++;
    }
}

string new_message = new String(reversedMessage);
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");