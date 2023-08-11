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

        //Klasse Complex
        Complex a = new Complex(100.0, 200.0);
        Complex b = new Complex(400.0, 500.0);
        Complex c = a + b;
        c += a;
        Console.WriteLine(c.Real + "+ i" + c.Imaginaer);

        Complex d, e;
        d = new Complex(0.0, 0.0);
        e = d++;
        Console.WriteLine(e.Real + "+ i" + e.Imaginaer);
        e = ++d;
        Console.WriteLine(e.Real + "+ i" + e.Imaginaer);

        //Klasse Indexer
        Fussballmannschaft bvb = new Fussballmannschaft();
        bvb[0] = new Spieler("Hummels", 15);
        bvb[1] = new Spieler("Reus", 11);
        Console.WriteLine("Spieler {0} mit der Nummer {1}", bvb[1].Name, bvb[1].Nummer);

        //Klasse Delegate
        Delegate.Greetings g;
        // g("Alf");
        g = new Delegate.Greetings(Delegate.SayHello);
        g("Bill");
        g = Delegate.SayHallo;
        g("Bob");
        g += Delegate.SayHello;
        g("Boss");

        //Typumwandlung, OverflowException

        //Variante1
        // for (int i = 254; i < 259; i++)
        // {
        //     byte by = (byte)i;
        //     Console.WriteLine(by);
        // }

        //Variante2
        // try
        // {
        //     checked
        //     {
        //         for (int i = 254; i < 259; i++)
        //         {
        //             byte byt = (byte)i;
        //             Console.WriteLine(byt);
        //         }
        //     }
        // }
        // catch (System.OverflowException)
        // {
        //     Console.WriteLine("Arithmetischer Überlauf");
        // }

        //Variante3
        checked
        {
            try
            {
                for (int i = 254; i < 259; i++)
                {
                    byte byt = (byte)i;
                    Console.WriteLine(byt);
                }
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Arithmetischer Überlauf");
            }
        };
    }
}