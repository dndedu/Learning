struct Punkt { public double x; public double y; }
abstract class Form
{
    private Punkt bezugspunkt;
    public Form(Punkt p) { this.bezugspunkt = p; }
    public abstract double BerechneFlaeche();
}
class Rechteck : Form
{
    private double breite;
    private double hoehe;
    public Rechteck(Punkt p, double b, double h) : base(p)
    {
        this.breite = b;
        this.hoehe = h;
    }
    public override double BerechneFlaeche()
    {
        return breite * hoehe;
    }
}