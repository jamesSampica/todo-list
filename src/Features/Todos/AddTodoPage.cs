using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using TodoList.Routing;

namespace TodoList.Features.Todos;

public partial class AddTodoPage() : ComponentBase, IRouteDefinition
{
    public void MapRoutes(WebApplication app)
    {
        app.MapPost("/todos/add", AddTodo);
    }

    public IResult AddTodo([FromForm] TodoItem todoItem)
    {
        TodosRepository.Todos.Add(todoItem);
        
        return Results.Redirect("/todos");
    }
}