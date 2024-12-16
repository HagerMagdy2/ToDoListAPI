using Microsoft.EntityFrameworkCore;

namespace ToDoListAPI.Models
{
    public class ToDoListContext:DbContext
    {
        public ToDoListContext()
        {
            
        }
        public ToDoListContext(DbContextOptions<ToDoListContext> Option) : base(Option)
        {
        }
        public virtual DbSet<Task> Tasks { get; set; }

    }
}
