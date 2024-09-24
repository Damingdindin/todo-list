using Microsoft.EntityFrameworkCore;
using todolist.Models;

namespace todolist.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Todo> Todos { get; set; }
    }
}
