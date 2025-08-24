namespace WebApi.Models;

public class Tag
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    // Navigation property for the many-to-many relationship
    public ICollection<TodoItemTag> TodoItemTags { get; set; } = new List<TodoItemTag>();
}
