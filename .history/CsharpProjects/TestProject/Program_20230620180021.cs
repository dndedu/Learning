using System;

int heroHP = 10;
int monsterHP = 10;
Random hit = new Random();

Boolean heroesTurn = true;

do
{
    if (heroesTurn)
    {
        monsterHP -= hit.Next(1, 11);
        heroesTurn = false;
    }
    else
    {
        heroHP -= hit.Next(1, 11);
        heroesTurn = true;
    }

} while (heroHP > 0 || monsterHP > 0);