namespace StarwarAPI.Controllers;

using Microsoft.AspNetCore.Mvc;
using BusinessLayer;
using BusinessLayer.Models;

[ApiController]
[Route("/api/[controller]")]
public class UserController: ControllerBase {

    private readonly IUserService _userService;

    public UserController(IUserService userService) {
        _userService = userService;
    }

    [HttpGet]
    public async Task<ActionResult<List<User>>> GetAll() {
        var users = await _userService.getAllUser();
        return Ok(users);
    }

    [HttpPost]
    public async Task<ActionResult<User>> Create(createUserDTO userData) {
        var user = await _userService.createUser(userData);
        return user;
    }

}