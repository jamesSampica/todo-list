
namespace TodoList;

public class HomePage : IRouteDefinition
{
    public void MapRoutes(WebApplication app)
    {
        app.MapGet("/", () => Results.Ok("Hello World"));
    }
}
