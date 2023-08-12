public class Delegate{
    public delegate void Greetings (string name);
    // public delegate void Greetings(string name)
    // {
    //     Console.WriteLine("Guten Tag " + name);
    // }

    public static void SayHello(string name)
    {
        Console.WriteLine("Hello " + name);
    }

    public static void SayHallo(string name)
    {
        Console.WriteLine("Hallo " + name);
    }
}