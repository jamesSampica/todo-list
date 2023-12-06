namespace TodoList.Features.Todos;

public static class TodosRepository
{
    public static List<TodoItem> Todos { get; } = [new(){Summary = "Dishes" },
                                                   new(){Summary = "Laundry" }];
}

public class TodoItem { public string? Summary { get; set; } }