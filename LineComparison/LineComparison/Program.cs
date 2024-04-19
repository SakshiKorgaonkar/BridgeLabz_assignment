// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
internal class LineComparison
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to line comparision computation program");
        Console.WriteLine("Enter first point coordinates");
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second point coordinates");
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Length of line is");
        double z = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        Console.WriteLine(z);
    }
}