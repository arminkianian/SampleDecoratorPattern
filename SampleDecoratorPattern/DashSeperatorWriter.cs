

public class DashSeperatorWriter : IWriter
{
    private readonly IWriter _writer;

    public DashSeperatorWriter(IWriter writer)
    {
        _writer = writer;
    }

    public void Write()
    {
        Console.WriteLine("----------------");
        _writer.Write();
        Console.WriteLine("----------------");
    }
}
