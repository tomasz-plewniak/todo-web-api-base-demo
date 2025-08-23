namespace WebApi.Models;

// This is the join entity for the many-to-many relationship between TodoItem and Tag
public class TodoItemTag
{
    public Guid TodoItemId { get; set; }
    public TodoItem TodoItem { get; set; } = default!;

    public Guid TagId { get; set; }
    public Tag Tag { get; set; } = default!;

    public DateTime AssignedAt { get; set; } = DateTime.UtcNow;
}
