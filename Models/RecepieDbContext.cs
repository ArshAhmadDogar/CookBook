using Microsoft.EntityFrameworkCore;
namespace CookBook.Models{
    public class RecepieDbContext:DbContext{
        public RecepieDbContext(DbContextOptions<RecepieDbContext> options) : base(options)
        {
            
        }

        public DbSet<Recepie> Recepies {get;set;}
        public DbSet<User> Users {get;set;}
        public DbSet<Comments> Comments {get;set;}
    }
}