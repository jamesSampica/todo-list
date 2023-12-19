
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TodoList.Routing;

namespace TodoList.Features.Todos;

public partial class TodosPage : ComponentBase, IRouteDefinition
{
    public void MapRoutes(WebApplication app)
    {
        var todos = app.MapGroup("/todos");

        todos.MapGet("/list", TodosList);
        todos.MapDelete("/delete", DeleteTodo);
        todos.MapGet("/delete/modal", DeleteModal);

    }

    public IResult TodosList()
    {
        return new RazorComponentResult<TodosListComponent>();
    }

    public RazorComponentResult<DeleteTodoModal> DeleteModal(Guid todoId) => new(todoId);

    public RazorComponentResult<TodosListComponent> DeleteTodo([FromForm] Guid todoId)
    {
        TodosRepository.Todos.Remove(TodosRepository.Todos.First(t => t.TodoId == todoId));

        return new();
    }
}