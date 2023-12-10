using Microsoft.AspNetCore.Components;
using TodoList.Routing;

namespace TodoList.Features.Home;

public partial class HomePage : ComponentBase, IRouteDefinition
{
    protected override Task OnInitializedAsync()
    {
        return base.OnInitializedAsync();
    }

    public override Task SetParametersAsync(ParameterView parameters)
    {
        return base.SetParametersAsync(parameters);
    }

    public void MapRoutes(WebApplication app)
    {
        app.MapGet("/route", Route);
    }

    public IResult Route()
    {
        return Results.Ok();
    }
}
