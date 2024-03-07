using Microsoft.EntityFrameworkCore;

namespace TaskManager.repository;

public class UserContext : DbContext{

    public UserContext(DbContextOptions<UserContext> options) : base(options){
    }
}