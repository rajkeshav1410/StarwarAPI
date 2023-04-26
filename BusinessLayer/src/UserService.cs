namespace BusinessLayer;

using RepoLayer;
using RepoLayer.Models;
using BusinessLayer.Models;
using Microsoft.EntityFrameworkCore;

public class UserService: IUserService {

    private readonly DataContext _context;

    public UserService(DataContext context) {
        _context = context;
    }

    public async Task<List<User>> getAllUser() {
        return await _context.Users.ToListAsync();
    }

    public Task<User> createUser(createUserDTO user) {
        return null;
    }

}
