﻿using System;

int[][] tDA = new int { { 1, 2 }, { 3, 4 } };

foreach (int[] a in tDA)
{
    foreach (int b in a)
    {
        Console.WriteLine(b);
    }
}