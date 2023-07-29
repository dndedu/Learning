public class Spieler
{
    public string Name{get; set;}
    public int Nummer{get; set;}

    public Spieler(string name, int nummer)
    {
        Name = name;
        Nummer = nummer;
    }
}

public class Fussballmannschaft
{
    private Spieler[] team = new Spieler[25];
    public Spieler this[int index]
    {
        get { return team[index]; }
        set { team[index] = value; }
    }
}