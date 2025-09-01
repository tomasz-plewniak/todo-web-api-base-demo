using System.ComponentModel.DataAnnotations;

namespace WebApi.Models;

public record CreateUser(
    [Required]
    [Length(1, 50)]
    string UserName,
    [Required]
    [EmailAddress]
    string Email);