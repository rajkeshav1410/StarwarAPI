using Microsoft.AspNetCore.Mvc;
// using RepoLayer;

namespace StarwarAPI.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class UserController: ControllerBase {
    [HttpGet]
    public async Task<ActionResult<List<User>>> Get() {
        List<User> user_list = new List<User>() {
            new User { 
                Id = 1, 
                FirstName = "Peter", 
                LastName = "Gryffin", 
                Email = "peter@starwar.com" 
            },
            new User { 
                Id = 1, 
                FirstName = "Peter", 
                LastName = "Parker", 
                Email = "pparker@starwar.com" 
            },
            new User { 
                Id = 1, 
                FirstName = "Iron", 
                LastName = "Man", 
                Email = "avenger@starwar.com" 
            }
        };

        return NotFound(user_list);
    }
}