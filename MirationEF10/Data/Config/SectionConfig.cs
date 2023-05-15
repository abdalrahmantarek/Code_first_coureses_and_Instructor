using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MirationEF10.Entities;

namespace MirationEF10.Data.Config
{
    public class SectionConfig : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.SectionName).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();

            builder.HasOne(x=>x.Course)
                .WithMany(x=>x.Sections)
                .HasForeignKey(x=>x.CourseId)
                .IsRequired();

            builder.HasOne(x => x.Instructor)
               .WithMany(x => x.Sections)
               .HasForeignKey(x => x.InstructorId)
               .IsRequired(false);
            builder.HasMany(c => c.Schedules).WithMany(x => x.Sections).UsingEntity<SectionSchedule>();

            builder.HasMany(x => x.Students)
                .WithMany(x => x.Sections)
                .UsingEntity<SectionStudent>();

            builder.ToTable("Sections");
            builder.HasData(LoadData());

        }

        private List<Section> LoadData()
        {
            return new List<Section>()
            {
                new Section{ Id=1 ,SectionName= "S-MA1" , CourseId= 1 , InstructorId=1 },
                new Section{ Id=2 ,SectionName= "S-MA2" , CourseId= 1 , InstructorId=2 },
                new Section{ Id=3 ,SectionName= "S-MA3" , CourseId= 2 , InstructorId=3 },
                new Section{ Id=4 ,SectionName= "S-MA4" , CourseId= 2 , InstructorId=2 },
                new Section{ Id=5 ,SectionName= "S-MA5" , CourseId= 3 , InstructorId=3 },
                new Section{ Id=6 ,SectionName= "S-MA6" , CourseId= 3 , InstructorId=5 },
                new Section{ Id=7 ,SectionName= "S-MA7" , CourseId= 4 , InstructorId=4 },
                new Section{ Id=8 ,SectionName= "S-MA8" , CourseId= 4 , InstructorId=4 },
                new Section{ Id=9 ,SectionName= "S-MA9" , CourseId= 5 , InstructorId=2 },
                new Section{ Id=10 ,SectionName= "S-MA10" , CourseId= 5 , InstructorId=1 },

            };
        }
    }
}
