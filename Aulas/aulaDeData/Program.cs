// See https://aka.ms/new-console-template for more information


namespace aulaDeData;

internal class Program
{
    public static void Main(string[] args)
    {
        var dateTime = DateTime.Now;
        
        Console.WriteLine(dateTime.ToLocalTime());
    }
}