using WebApi.Models;

namespace WebApi.Services;

public class TodoItemService : ITodoItemService
{
    public Task<IEnumerable<TodoItem>> GetTodoItemsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TodoItem?> GetTodoItemAsync(Guid id)
    {
        throw new NotImplementedException();
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