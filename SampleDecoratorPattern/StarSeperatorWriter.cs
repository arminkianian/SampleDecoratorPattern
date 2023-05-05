


public class StarSeperatorWriter : IWriter
{
    private readonly IWriter _writer;

    public StarSeperatorWriter(IWriter writer)
    {
        _writer = writer;
    }

    public void Write()
    {
        Console.WriteLine("****************");
        _writer.Write();
        Console.WriteLine("****************");
    }
}