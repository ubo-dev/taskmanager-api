using TaskManager.model;

namespace TaskManager.dto;

public record UserUpdateRequest (string FirstName, string LastName, Team Team){
    
}