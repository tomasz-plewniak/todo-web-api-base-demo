using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("/api/todo-items")]
public class TodoItemsController : ControllerBase
{
    private readonly ITodoItemService _todoItemService;

    public TodoItemsController(ITodoItemService todoItemService)
    {
        _todoItemService = todoItemService;
    }
    
    [HttpGet]
    public async Task<IActionResult>  GetTodoItemsAsync()
    {
        return Ok(await _todoItemService.GetTodoItemsAsync());
    }

    [HttpGet("{id}")]
    [ActionName(nameof(GetTodoItemAsync))]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetTodoItemAsync(Guid id)
    {
        TodoItem? todoItem = await _todoItemService.GetTodoItemAsync(id);
        
        if (todoItem == null)
        {
            return NotFound();
        }
        
        return Ok(todoItem);
    }

    [HttpPost]
    [ActionName(nameof(CreateTodoItemAsync))]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateTodoItemAsync(CreateTodoItem createTodoItem)
    {
        TodoItem todoItem = new()
        {
            Title = createTodoItem.Title,
            Description = createTodoItem.Description,
            DueDate = createTodoItem.DueDate,
            Priority = createTodoItem.Priority,
            UserId = createTodoItem.UserId
        };

        await _todoItemService.CreateTodoItemAsync(todoItem);
        
        return CreatedAtAction(
            nameof(GetTodoItemAsync),
            new {id = todoItem.Id},
            todoItem); 
    }
    
    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateTodoItemAsync(Guid id, UpdateTodoItem updateTodoItem)
    {
        throw new NotImplementedException();   
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTodoItemAsync(Guid id)
    {
        throw new NotImplementedException();  
    }
}