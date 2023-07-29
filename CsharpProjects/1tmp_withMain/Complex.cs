public struct Complex
{
    public double Real { get; set;}
    public double Imaginaer { get; set; } 

    public Complex(double r, double i) : this()
    { 
        Real = r;
        Imaginaer = i;
    } 

    //Operatorüberladung
    public static Complex operator+(Complex a, Complex b)
    {
        Complex result = new Complex();
        result.Real = a.Real + b.Real;
        result.Imaginaer = a.Imaginaer + b.Imaginaer;
        return result;
    }

    public static Complex operator++(Complex a) {
        return new Complex(a.Real + 1, a.Imaginaer);
    }
}