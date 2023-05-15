using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MirationEF10.Data.Config
{
    public class ScheduleConfig : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Title).HasColumnType("VARCHAR").HasMaxLength(255).IsRequired();
            
            builder.ToTable("Schedules");
            builder.HasData(LoadData());

        }

        private List<Schedule> LoadData()
        {
            return new List<Schedule>()
            {
              new Schedule { Id = 1,Title="Daily" ,SAT=true , SUN=true ,MON=false,
                            TUS=true ,WEN =true ,THU=true , FRI=true },
              new Schedule { Id = 2,Title="Daily" ,SAT=true , SUN=false ,MON=true,
                            TUS=true ,WEN =true ,THU=true , FRI=true },
              new Schedule { Id = 3,Title="Daily" ,SAT=false , SUN=true ,MON=true,
                            TUS=true ,WEN =false ,THU=true , FRI=true },
              new Schedule { Id = 4,Title="Daily" ,SAT=true , SUN=true ,MON=true,
                            TUS=false ,WEN =true ,THU=true , FRI=true },
              new Schedule { Id = 5,Title="Daily" ,SAT=true , SUN=true ,MON=true,
                            TUS=true ,WEN =true ,THU=true , FRI=false  },
            };
        }
    }
}
