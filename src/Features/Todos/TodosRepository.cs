namespace TodoList.Features.Todos;

public static class TodosRepository
{
    public static List<TodoItem> Todos { get; } = [new(){ TodoId = Guid.NewGuid(), Summary = "Dishes" },
                                                   new(){ TodoId = Guid.NewGuid(), Summary = "Laundry" }];
}

public record TodoItem
{
    public required Guid TodoId { get; set; }
    public required string Summary { get; set; }
}