﻿string[] values = { "12,3", "45", "ABC", "11", "DEF" };

string message = "";
decimal total = 0;

foreach (string item in values)
{
    decimal d;
    int i;
    if (decimal.TryParse(item, out d))
    {
        total += d;
    }
    else if (int.TryParse(item, out i))
    {
        total += i;
    }
    else
    {
        message += item;
    }
}

Console.WriteLine($"Message: {message}\nTotal: {total}");