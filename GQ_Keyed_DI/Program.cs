using GQ_Keyed_DI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(o => o.AddPolicy(
    "AllowAll",
    corsBuilder =>
    {
        corsBuilder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    }));

// comment next line to fix a broken api.
builder.Services.AddKeyedSingleton<ISomeService, SomeService>("key");

builder.Services
    .AddGraphQLServer()
    .AddQueryType(x => x.Name(OperationTypeNames.Query))
    .AddType<Query>();

var app = builder.Build();
app.UseCors("AllowAll");
app.MapGraphQL();
app.Run();
