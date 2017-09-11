using Microsoft.EntityFrameworkCore;
using StudentCatalog.Models.Entites;

namespace StudentCatalog.Models
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Filename=./StudentCatalog.db");
         }
        
    }
   
}