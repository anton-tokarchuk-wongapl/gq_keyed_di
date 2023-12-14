namespace GQ_Keyed_DI;

[ExtendObjectType(OperationTypeNames.Query)]
public sealed class Query
{
    public string Hello() => nameof(Hello);
}
