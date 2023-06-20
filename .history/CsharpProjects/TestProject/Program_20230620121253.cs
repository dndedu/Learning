using System;

int[][] tDA = { { 1, 2 }, { 3, 4 } };

foreach (int[] a in tDA)
{
    foreach (int b in a)
    {
        Console.WriteLine(b);
    }
}