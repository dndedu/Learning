using System;

int[,] tDA = { { 1, 2 }, { 3, 4 } };

foreach (var a in tDA)
{
    foreach (var b in a)
    {
        Console.WriteLine(b);
    }
}