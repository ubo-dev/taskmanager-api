using TaskManager.model;

namespace TaskManager.dto;

public record UserDto(int UserId, string FirstName, string LastName, Team Team);