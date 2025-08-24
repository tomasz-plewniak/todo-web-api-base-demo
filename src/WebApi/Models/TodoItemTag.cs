namespace WebApi.Models;

public class TodoItemTag
{
    public Guid TodoItemId { get; set; }
    public TodoItem TodoItem { get; set; } = default!;

    public Guid TagId { get; set; }
    public Tag Tag { get; set; } = default!;

    public DateTime AssignedAt { get; set; } = DateTime.UtcNow;
}
