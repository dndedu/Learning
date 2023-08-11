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
static int Main()
{
    Point p1;
    p1.x = 10;
    p1.y = 20;
    Point p2 = new Point(50, 70);
    Point p3 = p2;
    p3.x = 100;
    p3.y = 200;
}