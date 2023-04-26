namespace RepoLayer.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id
    { get; set; }
    public string FirstName 
    { get; set; } = string.Empty;
    public string LastName 
    { get; set; } = string.Empty;
    public string Email 
    { get; set; } = string.Empty;
    public int age 
    { get; set; } = int.MaxValue;

}