namespace TodoList.Features.Todos;

public static class TodosRepository
{
    public static List<TodoItem> Todos { get; } = [new("Dishes"), new("Laundry")];
}

public record TodoItem(string Summary);