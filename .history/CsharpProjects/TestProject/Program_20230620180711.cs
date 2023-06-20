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

} while (heroHP > 0 || monsterHP > 0);

if (heroesTurn == false)
    Console.WriteLine("Hero wins!");
else
    Console.WriteLine("Monster wins!");