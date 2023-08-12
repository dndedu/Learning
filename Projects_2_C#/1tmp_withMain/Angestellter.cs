class Angestellter
{
    private string name;
    private double gehalt;
    public Angestellter(string name, double gehalt)
    {
        this.name = name;
        this.gehalt = gehalt;
    }
    public void SetName(string name) { this.name = name; }
    public string GetName() { return name; }
    public void SetGehalt(double gehalt) { this.gehalt = gehalt; }
    public double GetGehalt() { return gehalt; }
    public double BerechneJahreszahlung() { return 12.0 * gehalt; }
}