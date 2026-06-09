using Microsoft.EntityFrameworkCore;
using Todo_Backend.Models;

namespace Todo_Backend.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();

    public DbSet<TodoTask> Tasks => Set<TodoTask>(
        
    );
}