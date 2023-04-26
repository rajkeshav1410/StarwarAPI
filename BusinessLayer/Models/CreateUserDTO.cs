namespace BusinessLayer.Models;

using System.ComponentModel.DataAnnotations;

public class createUserDTO {

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public int Age { get; set; }
    
}