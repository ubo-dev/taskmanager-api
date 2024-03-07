using TaskManager.dto;
using TaskManager.model;

namespace TaskManager.repository;

public interface IUserInterface
{
    IEnumerable<UserDto> GetUsers();
    UserDto GetUserById(int userId);
    void CreateUser(UserCreateRequest request);
    void UpdateUser(UserUpdateRequest request);
}