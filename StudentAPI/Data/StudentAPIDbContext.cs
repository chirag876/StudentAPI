using Microsoft.EntityFrameworkCore;
using StudentAPI.Model;

namespace StudentAPI.Data
{
    public class StudentAPIDbContext:DbContext
    {
        public StudentAPIDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Student> StudentDetails { get; set; }
    }
}
