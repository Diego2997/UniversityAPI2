using Microsoft.EntityFrameworkCore;
using UniversityAPI2.Models.DataModels;

namespace UniversityAPI2.DataAccess
{
    public class UniversityDBContext2 : DbContext
    {
        public UniversityDBContext2(DbContextOptions<UniversityDBContext2> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
