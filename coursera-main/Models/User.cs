using System.ComponentModel.DataAnnotations;

namespace UserManagementApi.Models;

public class User
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Email must be valid")]
    public string Email { get; set; } = string.Empty;
    
    [Range(1, int.MaxValue, ErrorMessage = "Age must be greater than 0")]
    public int Age { get; set; }
}