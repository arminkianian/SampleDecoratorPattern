internal class Program
{
    private static void Main(string[] args)
    {
        CreateWriter();

        Console.ReadLine();
    }

    private static void CreateWriter()
    {
        IWriter writer = new Writer();

        Console.WriteLine("Insert Dashes?");
        var dashResponse = Console.ReadLine();
        if (dashResponse.ToLower() == "y")
        {
            writer = new DashSeperatorWriter(writer);
        }

        Console.WriteLine("Insert Stars?");
        var starResponse = Console.ReadLine();
        if (starResponse.ToLower() == "y")
        {
            writer = new StarSeperatorWriter(writer);
        }

        writer.Write();
    }
}
