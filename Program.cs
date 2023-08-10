using HotChocolateIssue;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

app.MapGraphQL();
app.MapGet("/", () => Results.Redirect("/graphql"));

app.Run();
