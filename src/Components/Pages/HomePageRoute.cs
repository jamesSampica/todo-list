
using Microsoft.AspNetCore.Http.HttpResults;
using TodoList.Components.Pages;

namespace TodoList;

public class HomePageRoute : IRouteDefinition
{
    public void MapRoutes(WebApplication app)
    {
        app.MapGet("/", HomePage);
    }

    public IResult HomePage()
    {
        return new RazorComponentResult<HomePage>();
    }
}
