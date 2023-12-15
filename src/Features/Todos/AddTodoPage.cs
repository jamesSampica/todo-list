using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace TodoList.Features.Todos;

public partial class AddTodoPage : ComponentBase
{
    [Inject]
    public NavigationManager Nav { get; set; } = null!;

    [SupplyParameterFromForm]
    public TodoItemForm _todoItem { get; set; } = new() { Summary = "Vacuum" };

    public void AddTodo()
    {
        TodosRepository.Todos.Add(new() { TodoId = Guid.NewGuid(), Summary = _todoItem.Summary! });

        Nav.NavigateTo("/todos");
    }

    public class TodoItemForm { [Required] public string? Summary { get; set; } }
}