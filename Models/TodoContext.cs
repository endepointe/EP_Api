using Microsoft.EntityFrameworkCore;

namespace EP_Api.Models
{
  public class TodoContext : DbContext
  {
    public TodoContext(DbContextOptions<TodoContext> options)
      : base(options)
    {
    
    } 

    public DbSet<TodoItem> TodoItems { get; set; }
  }
}