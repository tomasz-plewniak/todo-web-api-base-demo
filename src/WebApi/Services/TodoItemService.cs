using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Services;

public class TodoItemService : ITodoItemService
{
    private readonly AppDbContext _context;

    public TodoItemService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<TodoItem>> GetTodoItemsAsync()
    {
        return await _context.TodoItems.ToListAsync();
    }

    public async Task<TodoItem?> GetTodoItemAsync(Guid id)
    {
        return await _context.TodoItems.SingleOrDefaultAsync(t => t.Id == id);
    }

    public Task<TodoItem> CreateTodoItemAsync(CreateTodoItem createTodoItem)
    {
        throw new NotImplementedException();
    }

    public Task<TodoItem> UpdateTodoItemAsync(Guid id, UpdateTodoItem updateTodoItem)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTodoItemAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}