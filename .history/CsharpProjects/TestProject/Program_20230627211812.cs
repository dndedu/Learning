string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string message = "";
decimal total = 0;

foreach (string item in values)
{
    decimal d;
    if (decimal.TryParse(item, out d))
    {
        total += d;
    }
    else
    {
        message += item;
    }
}

Console.WriteLine($"Message: {message}\nTotal: {total}");