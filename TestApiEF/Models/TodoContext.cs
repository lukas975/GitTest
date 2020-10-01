using Microsoft.EntityFrameworkCore;

namespace TestApiEF.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }






        //public DbSet<Movie> Movies { get; set; }


        //public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        //{
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<TodoItem>().ToTable("TodoItem");
            modelBuilder.Entity<TodoItem>().HasData(new TodoItem 
            { 
                Id = 1,
                Name = "name", 
            }, new TodoItem
            {
                Id = 2,
                Name = "name",
            });
        }
    }
}
