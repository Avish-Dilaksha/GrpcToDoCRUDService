using GrpcToDoCRUDService.Models;
using Microsoft.EntityFrameworkCore;

namespace GrpcToDoCRUDService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<ToDoItem> ToDoItems => Set<ToDoItem>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add some dummy data here
            modelBuilder.Entity<ToDoItem>().HasData(
                new ToDoItem
                {
                    Id = 1,
                    Title = "Buy groceries",
                    Description = "Milk, eggs, bread, and cheese",
                    ToDoStatus = "New"
                },
                new ToDoItem
                {
                    Id = 2,
                    Title = "Complete homework",
                    Description = "Finish math and science homework",
                    ToDoStatus = "InProgress"
                },
                new ToDoItem
                {
                    Id = 3,
                    Title = "Clean the house",
                    Description = "Vacuum, mop, and organize the living room",
                    ToDoStatus = "Completed"
                }
            );
        }
    }
}
