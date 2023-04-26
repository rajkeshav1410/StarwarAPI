namespace BusinessLayer;

using RepoLayer.Models;
using BusinessLayer.Models;

public interface IUserService {

    public Task<List<User>> getAllUser();

    public Task<User> createUser(createUserDTO user);

}