
namespace TodoList;

public class HomePage : IRouteDefinition
{
    public void Map(WebApplication app)
    {
        app.MapGet("/", () => Results.Ok("Hello World"));
    }
}
