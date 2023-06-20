using System;

int[,] tDA = new int[2, 2] { { 1, 2 }, { 3, 4 } };

foreach (int a[] in tDA)
{
    foreach (int b in a)
    {
        Console.WriteLine(b);
    }
}

foreach (int i in Enumerable.Range(0, tDA.GetLength(0)))
    foreach (int j in Enumerable.Range(0, tDA.GetLength(1)))
        Console.WriteLine(tDA[i, j]);