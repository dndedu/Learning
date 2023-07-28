namespace _1tmp_withMain;

class Start
{
    struct Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Point p1;
        p1.x = 10;
        p1.y = 20;
        Point p2 = new Point(50, 70);
        Point p3 = p2;
        p3.x = 100;
        p3.y = 200;
        Console.WriteLine($"p2.x: {p2.x}; p2.y: {p2.y}");

        //Klasse Angestellter
        Angestellter angestellter = new Angestellter("Alf", 100000);
        Console.WriteLine(angestellter.GetName());

        //Klasse StructForm
        Punkt p;
        p.x = 0;
        p.y = 0;
        Rechteck r = new Rechteck(p, 5.0, 10.0);
        Console.WriteLine($"Fläche des Rechtecks: {r.BerechneFlaeche()}");
    }
}