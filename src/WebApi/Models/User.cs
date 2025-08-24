namespace WebApi.Models;

public class User
{
    public Guid Id { get; set; }
    
    public required string UserName { get; set; }
    
    public required string Email { get; set; }

    public DateTime CreatedAt { get; set; }
    
    public DateTime UpdatedAt { get; set; }
}
