using WebApi.Models;

namespace WebApi.Services;

public interface ITodoItemService
{
    public Task<IEnumerable<TodoItem>> GetTodoItemsAsync();
    
    public Task<TodoItem?> GetTodoItemAsync(Guid id);
    
    public Task<TodoItem> CreateTodoItemAsync(CreateTodoItem createTodoItem);
    
    public Task<TodoItem> UpdateTodoItemAsync(Guid id, UpdateTodoItem updateTodoItem);
    
    public Task DeleteTodoItemAsync(Guid id);
}