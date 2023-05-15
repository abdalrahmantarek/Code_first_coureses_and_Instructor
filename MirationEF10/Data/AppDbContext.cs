using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MirationEF10.Data.Config;
using MirationEF10.Entities;

namespace MirationEF10.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Course> Courses { get; set; }

        public DbSet<Instructor> Instructors { get; set; } 
        
        public DbSet<Office> Offices { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<Section> Sections { get; set; }

        public DbSet<SectionSchedule> SectionSchedules { get; set; }

        public DbSet<SectionStudent> SectionStudents { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var constr = config.GetSection("constr").Value;

            optionsBuilder.UseSqlServer(constr);
            optionsBuilder.EnableSensitiveDataLogging();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
