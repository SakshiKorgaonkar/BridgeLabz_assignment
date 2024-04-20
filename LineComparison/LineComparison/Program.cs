// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Runtime.CompilerServices;

internal class LineComparison
{
    int x1;
    int y1;
    int x2;
    int y2;

    LineComparison()
    {
        x1 = 0;
        y1 = 0;
        x2 = 0;
        y2 = 0;
    }
    void AcceptRecord()
    {
        Console.WriteLine("Enter first point coordinates");
        x1 = Convert.ToInt32(Console.ReadLine());
        y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second point coordinates");
        x2 = Convert.ToInt32(Console.ReadLine());
        y2 = Convert.ToInt32(Console.ReadLine());
    }
    double Length() 
    {
        double z = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        return z;
    }
    void Compare(double a,double b)
    {
        if(a.Equals(b))
        {
            Console.WriteLine("The lengths are equal");
        }
        else if (b > a)
        {
            Console.WriteLine("Length of second line is greater than first");
        }
        else
        {
            Console.WriteLine("Length of first line is greater than first");
        }
    }
    void PrintRecord()
    { 
        Console.WriteLine("First point coordinates are "+ x1+", " +y1);
        Console.WriteLine("Second point coordinates are " + x2 + ", " + y2 );
    }
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to line comparision computation program");
        LineComparison lineComparison = new LineComparison();
        lineComparison.AcceptRecord();    
        lineComparison.PrintRecord();
        double a=lineComparison.Length();
        Console.WriteLine("Length of line1 is "+ a);

        lineComparison.AcceptRecord();
        lineComparison.PrintRecord();
        double b=lineComparison.Length();
        Console.WriteLine("Length of line2 is " + b);

        lineComparison.Compare(a,b);
    }
}