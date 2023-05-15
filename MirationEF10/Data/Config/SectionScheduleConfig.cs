using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MirationEF10.Data.Config
{
    public class SectionScheduleConfig : IEntityTypeConfiguration<SectionSchedule>
    {
        public void Configure(EntityTypeBuilder<SectionSchedule> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.StartTime).HasColumnType("time");
            builder.Property(x => x.EndTime).HasColumnType("time");
            builder.ToTable("SectionSchedules");
            builder.HasData(LodData());

        }

        private static List<SectionSchedule> LodData()
        {
            return new List<SectionSchedule>()
            {
                new SectionSchedule() { Id = 1,SectionId=1 , ScheduleId = 1, StartTime= TimeSpan.Parse("08:00:00"),EndTime = TimeSpan.Parse("10:00:00"),},
               
             
            };
        }
    }

}
