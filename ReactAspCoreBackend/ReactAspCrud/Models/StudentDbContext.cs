using Microsoft.EntityFrameworkCore;
namespace ReactAspCrud.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<NameModels> NameModel  { get; set; }
      
      //   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       // {
         // optionsBuilder.UseSqlServer("Data Source=dinm5cg3343d3l;Initial Catalog=Name;User= sa; password=Password@123; Trust Server Certificate=True");
        //}
    }
}
