using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult>  GetUsersAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetUserAsync(
        [FromRoute] Guid id,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> CreateUserAsync([FromBody] CreateUser createUser)
    {
        throw new NotImplementedException(); 
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateUserAsync(
        [FromRoute] Guid id
        // Add here update model)
        )
    {
        throw new NotImplementedException();   
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUserAsync(
        [FromRoute] Guid id)
    {
        throw new NotImplementedException();  
    }
}