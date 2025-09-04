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

    public async Task CreateTodoItemAsync(TodoItem todoItem)
    {
        await _context.TodoItems.AddAsync(todoItem);
        await _context.SaveChangesAsync();
    }

    public Task<TodoItem> UpdateTodoItemAsync(Guid id, UpdateTodoItem updateTodoItem)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteTodoItemAsync(Guid id)
    {
        TodoItem? todoItem = await _context.TodoItems.SingleOrDefaultAsync(t => t.Id == id);

        if (todoItem == null)
        {
            return;
        }
        
        _context.TodoItems.Remove(todoItem);
        await _context.SaveChangesAsync();
    }
}