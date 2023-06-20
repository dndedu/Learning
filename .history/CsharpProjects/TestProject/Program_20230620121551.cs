using System;

int[,] tDA = new int[2, 2] { { 1, 2 }, { 3, 4 } };

foreach (int a in tDA)
{
    foreach (int b in tDA[a])
    {
        Console.WriteLine(b);
    }
}