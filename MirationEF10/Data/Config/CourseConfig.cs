using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MirationEF10.Entities;

namespace MirationEF10.Data.Config
{
    public class CourseConfig : IEntityTypeConfiguration<Course> 
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).ValueGeneratedNever();
            builder.Property(x=>x.CourseName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();
            builder.Property(x => x.Price).HasPrecision(15, 2);
            builder.ToTable("Courses");
            builder.HasData(LoadData());

        }

        private List<Course> LoadData()
        {
            return new List<Course>()
            {
                new Course{ Id = 1, CourseName = "Html",Price = 1500m },
                new Course { Id = 2, CourseName = "CSS",Price = 1800m },
                new Course { Id = 3, CourseName = "JS",Price = 1000m },
                new Course { Id = 4, CourseName = "C#",Price = 2500m },
                new Course { Id = 5, CourseName = "C++",Price = 2200m },
            };
        }
    }
}
