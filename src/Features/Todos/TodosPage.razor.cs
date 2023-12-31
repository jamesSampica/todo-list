
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using TodoList.Routing;

namespace TodoList.Features.Todos;

public partial class TodosPage : ComponentBase, IRouteDefinition
{
    public void MapRoutes(WebApplication app)
    {
        var todos = app.MapGroup("/todos");

        todos.MapGet("/list", TodosList);
        todos.MapDelete("/delete/{todoId}", DeleteTodo);
        todos.MapGet("/delete/modal/{todoId}", DeleteModal);

    }

    public IResult TodosList()
    {
        return new RazorComponentResult<TodosListComponent>();
    }

    public RazorComponentResult<DeleteTodoModal> DeleteModal(Guid todoId) => new(new { todoId });

    public IResult DeleteTodo(Guid todoId)
    {
        TodosRepository.Todos.Remove(TodosRepository.Todos.First(t => t.TodoId == todoId));

        return Results.Content(string.Empty);
    }
}