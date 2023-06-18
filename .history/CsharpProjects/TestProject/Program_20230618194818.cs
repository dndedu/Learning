using System;

Random coinFlip = new Random();

int coinSide = coinFlip.Next(2);

Console.WriteLine($"{(coinSide == 0 ? "Heads" : "Tails")};