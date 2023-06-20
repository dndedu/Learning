using System;

int[][] a = { { 1, 2 }, { 3, 4, 5 } };

int[,] b = {
    {1, 2},
    {3, 4}
};

// int[] c = { 1, 2, 3, 4 };

//x  y   breite := 2 (2x2 grid)
// c[0, 0] == 0; // i = breite*y + x = 2*0 + 0 = 0
// c[1, 0] == 2; // i = breite*y + x = 2*0 + 1 = 1
// c[0, 1] == 3; // i = breite*y + x = 2*1 + 0 = 2
// c[1, 1] == 3; // i = breite*y + x = 2*1 + 1 = 3

foreach (int c in b)
{
    Console.WriteLine(c);
}

var collection = a;

foreach (var element in collection)
{

}