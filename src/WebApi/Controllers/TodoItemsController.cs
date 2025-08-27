using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
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
    public async Task<IActionResult> GetTodoItemAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> CreateTodoItemAsync(CreateTodoItem createTodoItem)
    {
        throw new NotImplementedException();
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