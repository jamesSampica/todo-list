
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using TodoList.Routing;

namespace TodoList.Features.Todos;

public partial class TodosPage : ComponentBase, ICanRoute
{
    public void MapRoutes(WebApplication app)
    {
        app.MapGet("/todos/list", TodosList);
    }

    public IResult TodosList()
    {
        return new RazorComponentResult<TodosListComponent>();
    }
}