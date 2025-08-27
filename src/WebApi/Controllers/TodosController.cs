using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TodosController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult>  GetTodoItemsAsync()
    {
        throw new NotImplementedException();
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