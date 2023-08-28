using Microsoft.EntityFrameworkCore;
using Project_Copy_Master.Models;

namespace Project_Copy_Master
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<addsinfo> addsinfo { get; set;}
        public DbSet<Commentsinfo> commentsinfo { get; set; }
        public DbSet<consultantinfo> Consultantinfo { get; set; }
        public DbSet<countryinfo> countryinfo { get; set; }
        public DbSet<embassyinfo> embassyinfo { get; set; }
        public DbSet<Formdata> formdata { get; set; }
        public DbSet<Instituteinfo> Instituteinfo { get; set; }
        public DbSet<MainViewsCounter> MainViewsCounter { get; set; }
        public DbSet<eventsinfo> newsandeventinfo { get; set; }
        public DbSet<scholarshipinfo> scholarshipinfo { get; set; }
        public DbSet<Studentinfo> Studentinfo { get; set; }
        public DbSet<Verify_login> Verify_login { get; set; }
        public DbSet<ViewsCounter> ViewsCounter { get; set; }
        public DbSet<Testsinfo> Testsinfo { get; set; }
        public DbSet<Coursesinfo> Coursesinfo { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
    }

}
