using System;

struct Point
{
    public int x;
    public int y;
}


struct Line
{
    public Point a;
    public Point b;
    public float distance
    {
        get
        {
            return MathF.Sqrt(MathF.Pow(a.x - b.x, 2) + MathF.Pow(a.y - b.y, 2));
        }

    }


}



class Program
{
    static void Main()
    {
        Line line1;
        line1.a.x = int.Parse(Console.ReadLine());
        line1.a.y = int.Parse(Console.ReadLine());
        line1.b.x = int.Parse(Console.ReadLine());
        line1.b.y = int.Parse(Console.ReadLine());

        Console.WriteLine(MathF.Round(line1.distance, 2));


    }
}
