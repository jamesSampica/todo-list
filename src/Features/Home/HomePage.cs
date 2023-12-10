using TodoList.Routing;

namespace TodoList;

public class HomeFeature : IRouteDefinition
{
    public void MapRoutes(WebApplication app)
    {
        app.MapGet("/", HomePage);
    }

    public IResult HomePage()
    {
        return Results.Ok();
    }
}
