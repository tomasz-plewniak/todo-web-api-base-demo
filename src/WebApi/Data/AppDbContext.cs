using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<TodoItem> TodoItems { get; set; }

    public DbSet<User> Users { get; set; }
    
    public DbSet<Category> Categories { get; set; }
    
    public DbSet<Tag> Tags { get; set; }
    
    public DbSet<TodoItemTag> TodoItemTags { get; set; }
}