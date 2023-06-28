/*
changed 12.3 to 12,3 after handling (the still to parse, but to expected)
int-values of the values-string-array separately in the foreach-loop,
which didn't change the initial result of 179

conclusion: start with atomic parts like the input values and their formatting;
in this case the issue is even located in the configuration
of how floating point values have to be written*/
string[] values = { "12,3", "45", "ABC", "11", "DEF" };

string message = "";
decimal total = 0;

foreach (string item in values)
{
    decimal d;
    // int i;
    if (decimal.TryParse(item, out d))
    {
        total += d;
    }
    // else if (int.TryParse(item, out i))
    // {
    //     total += i;
    // }
    else
    {
        message += item;
    }
}

Console.WriteLine($"Message: {message}\nTotal: {total}");