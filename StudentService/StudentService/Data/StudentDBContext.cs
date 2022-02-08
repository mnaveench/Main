using Microsoft.EntityFrameworkCore;
using StudentService.Models;

namespace StudentService.Data
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext()
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
