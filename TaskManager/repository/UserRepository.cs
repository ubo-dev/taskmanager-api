using TaskManager.dto;
using TaskManager.model;

namespace TaskManager.repository;

public class UserRepository : IUserInterface
{

    private readonly UserContext _userContext;

    public UserRepository(UserContext context)
    {
        this._userContext = context;
    }
    
    public IEnumerable<UserDto> GetUsers()
    {
        throw new NotImplementedException();
    }

    public UserDto GetUserById(int userId)
    {
        throw new NotImplementedException();
    }

    public void CreateUser(UserCreateRequest request)
    {
        throw new NotImplementedException();
    }

    public void UpdateUser(UserUpdateRequest request)
    {
        throw new NotImplementedException();
    }
}