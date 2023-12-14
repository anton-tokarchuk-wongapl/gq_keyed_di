namespace GQ_Keyed_DI;

public interface ISomeService
{
    string Hi();
}

public sealed class SomeService
    : ISomeService
{
    public string Hi()
    {
        return nameof(SomeService);
    }
}
