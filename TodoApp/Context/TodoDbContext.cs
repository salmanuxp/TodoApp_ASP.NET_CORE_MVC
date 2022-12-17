using TodoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoApp.Context
{
    public class TodoDbContext : DbContext

    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base
            (options)
        {
        }
        public DbSet<Todo> Todos { get; set; }

    }
}