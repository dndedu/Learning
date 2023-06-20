using System;

int heroHP = 10;
int monsterHP = 10;
Random hit = new Random();
int dmg;

Boolean heroesTurn = true;

do
{
    dmg = hit.Next(1, 11);
    if (heroesTurn)
    {
        monsterHP -= dmg;
        Console.WriteLine($"Monster was damaged and lost {dmg} health and now has {monsterHP} health.");
        heroesTurn = false;
    }
    else
    {
        heroHP -= dmg;
        Console.WriteLine($"Hero was damaged and lost {dmg} health and now has {heroHP} health.");
        heroesTurn = true;
    }

} while (heroHP > 0 && monsterHP > 0);

if (heroesTurn == false)
    Console.WriteLine("Hero wins!");
else
    Console.WriteLine("Monster wins!");


/* Solution of MS LearnTour

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!"); */