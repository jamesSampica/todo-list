
namespace TodoList;

public class HomePageRoute : IRouteDefinition
{
    public void MapRoutes(WebApplication app)
    {
        app.MapGet("/", Index);
    }

    public IResult Index()
    {
        return Page<HomePage>();
    }
}
