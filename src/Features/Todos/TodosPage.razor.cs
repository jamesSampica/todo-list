
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TodoList.Routing;

namespace TodoList.Features.Todos;

public partial class TodosPage : ComponentBase, IRouteDefinition
{
    public void MapRoutes(WebApplication app)
    {
        app.MapGet("/todos/list", TodosList);
        app.MapDelete("/todos/delete", DeleteTodo);
    }

    public RazorComponentResult TodosList()
    {
        return new RazorComponentResult<TodosListComponent>();
    }

    public IResult DeleteTodo([FromBody] Guid todoId)
    {
        TodosRepository.Todos.Remove(TodosRepository.Todos.First(t => t.TodoId == todoId));

        return new RazorComponentResult<TodosListComponent>();
    }
}