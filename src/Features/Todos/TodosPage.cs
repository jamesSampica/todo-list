


public class TodosFeature
{
    public void MapRoutes(WebApplication app)
    {
        app.MapGet("/todos", TodosPage);
    }

    public IResult TodosPage()
    {
        return Results.Ok();
    }
}